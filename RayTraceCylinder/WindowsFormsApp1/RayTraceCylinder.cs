// Chaitanya Ingle
// 2000475661
// CS 480
// Assignment 7 - Ray Tracing a Cylinder

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Media3D;

namespace RayTraceSphere
{
    public partial class RayTraceSphere : Form
    {
        //******************************************************************************************************
        // CLASS STRUCTURES
        //******************************************************************************************************

        public struct Cylinder
        {
            // Variables to hold center of cylinder
            public double X, Y, Z;

            // Variables for radius + height cylinder
            public double r, h;
        }
        //******************************************************************************************************
        // CLASS VARIABLES
        //******************************************************************************************************

        Vector3D V;                         // Holds directional vector from screen to cylinder
        Cylinder cylinder;                  // Holds cylinder to be traced
        Vector3D camera;                    // variable to store camera position/direction

        // Variables to store default values of user-changable variables
        // (Helps with resetting)

        // Camera variables
        string cam_box_X_def;
        string cam_box_Y_def;
        string cam_box_Z_def;

        // Cylinder variables
        string cyl_X_def;
        string cyl_Y_def;
        string cyl_Z_def;
        string cyl_r_def;
        string cyl_h_def;

        // Light variables
        string light_X_def;
        string light_Y_def;
        string light_Z_def;

        //******************************************************************************************************
        // CONSTRUCTOR
        //******************************************************************************************************

        public RayTraceSphere()
        {
            InitializeComponent();

            // Before input variables change, save default values
            cam_box_X_def = cam_X_input.Text;
            cam_box_Y_def = cam_Y_input.Text;
            cam_box_Z_def = cam_Z_input.Text;

            cyl_X_def = cyl_X_input.Text;
            cyl_Y_def = cyl_Y_input.Text;
            cyl_Z_def = cyl_Z_input.Text;
            cyl_r_def = cyl_r_input.Text;
            cyl_h_def = cyl_h_input.Text;

            light_X_def = light_X_input.Text;
            light_Y_def = light_Y_input.Text;
            light_Z_def = light_Z_input.Text;
        }

        //******************************************************************************************************
        // CLASS FUNCTIONS
        //******************************************************************************************************

        //--------------------------------------------------------------------------------------------------
        // Function to handle "DRAW!" button click. 
        // Draws canvas based on current class/input variables.
        private void draw_button_Click(object sender, EventArgs e)
        {
            // Delcare and/or set all necessary variables...

            // Get canvas size
            int c_width = pictureBox1.Width;
            int c_height = pictureBox1.Height;

            // Declare/ initalize Quadratic Equation variables
            double A = 0;
            double B = 0;
            double C = 0;
            double disc = 0; // (discriminant)

            // Declare/ initalize Parametric Equation variables
            double Xt = 0; 
            double Yt = 0; 
            double Zt = 0;
            double t1 = 0; // (parametric solution 1)
            double t2 = 0; // (parametric solution 2)

            // Variables to hold light source coordinates
            // NOTE: Stored as separate variables to make
            // math possible when using individual components
            double Lx = 0;
            double Ly = 0;
            double Lz = 0;

            Vector3D normal;          // normal vector from surface to where ray hits
            Vector3D light;           // vector from where ray hits to light
            double cos_theta = 0;      // angle between normal and light vector

            // Start try-catch block in case user input
            // cannot be converted to double
            try
            {
                // Get current camera location
                camera.X = Convert.ToDouble(cam_X_input.Text);
                camera.Y = Convert.ToDouble(cam_Y_input.Text);
                camera.Z = Convert.ToDouble(cam_Z_input.Text);
                
                // Get current cylinder parameters
                cylinder.X = Convert.ToDouble(cyl_X_input.Text);
                cylinder.Y = Convert.ToDouble(cyl_Y_input.Text);
                cylinder.Z = Convert.ToDouble(cyl_Z_input.Text);
                cylinder.r = Convert.ToDouble(cyl_r_input.Text); 
                cylinder.h = Convert.ToDouble(cyl_h_input.Text); 
                
                // Get current light location
                Lx = Convert.ToDouble(light_X_input.Text); 
                Ly = Convert.ToDouble(light_Y_input.Text);
                Lz = Convert.ToDouble(light_Z_input.Text);
                
                // Create bitmap to store image
                Bitmap bm = new Bitmap(c_width, c_height); 

                using (Graphics g = Graphics.FromImage(bm))
                {
                    g.Clear(Color.Teal); 

                    // Main ray tracing loop going through all pixels...

                    for (int Ys = 0; Ys < c_height; Ys++) 
                    {
                        for (int Xs = 0; Xs < c_width; Xs++) 
                        {
                            // Get vector from screen pixel to camera
                            V.X = Xs - camera.X;
                            V.Y = Ys - camera.Y;
                            V.Z = 0 - camera.Z;
                            
                            // Solves quadratic equation based on parametric equation
                            // Returns A, B, and C from quadratic solution
                            compute_quad_eq(ref A, ref B, ref C);

                            // Calculate discriminant
                            disc = (B * B) - (A * C); 

                            // Based on discriminant, determine how many points hit.
                            if (disc >= 0) // Case with 1 or 2 points of contact
                            {
                                // Get two t values
                                t1 = (-1 * B - Math.Sqrt(disc)) / A;
                                t1 = Math.Abs(t1);
                                t2 = (-1 * B + Math.Sqrt(disc)) / A;
                                t2 = Math.Abs(t2);

                                // Check if point is hitting within actual height of cylinder
                                if (Ys >= cylinder.Y && Ys <= cylinder.Y + cylinder.h)
                                {
                                    // Get parametric values
                                    compute_parametric(t1, ref Xt, ref Yt, ref Zt);

                                    // Calculate cos(theta) using normal directional and light vectors
                                    normal = compute_normal(Xt, Yt, Zt); 
                                    light = compute_light_ray(Lx, Ly, Lz, Xt, Yt, Zt); 
                                    cos_theta = compute_cos_theta(light, normal); 

                                    if (cos_theta > 0) // light hits directly, use direct + ambient light
                                        bm.SetPixel(Xs, Ys, Color.FromArgb(255, (int)(200 * cos_theta + 55), (int)(200 * cos_theta + 55), (int)(200 * cos_theta + 55))); 
                                    else              // light hits indirectly, use ambient light
                                        bm.SetPixel(Xs, Ys, Color.FromArgb(255, 55, 55, 55)); 

                                    if (t1 != t2) // If two unique points of contact, do same thing for second point
                                    {
                                        // Get parametric values
                                        compute_parametric(t2, ref Xt, ref Yt, ref Zt);

                                        // Calculate cos(theta) using normal directional and light vectors
                                        normal = compute_normal(Xt, Yt, Zt); 
                                        light = compute_light_ray(Lx, Ly, Lz, Xt, Yt, Zt); 
                                        cos_theta = compute_cos_theta(light, normal); 

                                        if (cos_theta > 0) // light hits directly, use direct + ambient light
                                            bm.SetPixel(Xs, Ys, Color.FromArgb(255, (int)(200 * cos_theta + 55), (int)(200 * cos_theta + 55), (int)(200 * cos_theta + 55))); //give it angle based light
                                        else              // light hits indirectly, use ambient light
                                            bm.SetPixel(Xs, Ys, Color.FromArgb(255, 55, 55, 55)); 
                                    }
                                }
                            }
                        }
                    }
                }

                // Draw bitmap to canvas
                pictureBox1.Image = bm;
            }

            // try-catch block set up to ensure good input.
            // Essentially, when input string cannot be
            // converted to double, throw general exception.
            catch (Exception)
            {
                MessageBox.Show("Invalid Input"); 
            }
        }


        //******************************************************************************************************
        // HELPER FUNCTIONS
        //******************************************************************************************************

        //--------------------------------------------------------------------------------------------------
        // Function to solve quadratic equation for 
        // intersection of light and cylinder in current camera setting.
        public void compute_quad_eq(ref double A, ref double B, ref double C)
        {
            A = V.X * V.X + V.Z * V.Z;
            B = V.X * (camera.X - cylinder.X) + V.Z * (camera.Z - cylinder.Z);
            C = (camera.X - cylinder.X) * (camera.X - cylinder.X) + (camera.Z - cylinder.Z) * (camera.Z - cylinder.Z) - (cylinder.r*cylinder.r);
        }

        //--------------------------------------------------------------------------------------------------
        // Function to solve basic parametric equations with passed t value 
        public void compute_parametric(double t, ref double Xt, ref double Yt, ref double Zt)
        {
            Xt = camera.X + V.X * t;
            Yt = camera.Y + V.Y * t;
            Zt = camera.Z + V.Z * t;
        }

        //--------------------------------------------------------------------------------------------------
        // Function to compute normal vector from center of cylinder to where ray hit on surface
        public Vector3D compute_normal(double Xt, double Yt, double Zt)
        {
            double n_X = Xt - cylinder.X;
            double n_Y = 0;
            double n_Z = Zt - cylinder.Z;

            return new Vector3D(n_X, n_Y, n_Z);
        }

        //--------------------------------------------------------------------------------------------------
        // Function to compute vector from where ray hit on surface to light source
        public Vector3D compute_light_ray(double Lx, double Ly, double Lz, double Xt, double Yt, double Zt)
        {
            double v_X = Lx - Xt;
            double v_Y = Ly - Yt;
            double v_Z = Lz - Zt;

            return new Vector3D(v_X, v_Y, v_Z);
        }

        //--------------------------------------------------------------------------------------------------
        // Calculates the cos (theta) between 2 passed in vectors
        public double compute_cos_theta(Vector3D v1, Vector3D v2)
        {
            // Store magnitudes to do math with them below...
            double v2_mag = v2.Length;
            double v1_mag = v1.Length;

            double dp = Vector3D.DotProduct(v1, v2);
            double cos_theta = dp / (v1_mag * v2_mag);

            return cos_theta;
        }

        //--------------------------------------------------------------------------------------------------
        // Function to handle "RESET" button click. 
        // Resets canvas and program variables.
        private void reset_button_Click(object sender, EventArgs e)
        {
            // Invalidate() does not work because
            // currently not using paint function for drawing.
            // Therefore, individually reset parameters.
            cam_X_input.Text = cam_box_X_def;
            cam_Y_input.Text = cam_box_Y_def;
            cam_Z_input.Text = cam_box_Z_def;

            cyl_X_input.Text = cyl_X_def;
            cyl_Y_input.Text = cyl_Y_def;
            cyl_Z_input.Text = cyl_Z_def;
            cyl_r_input.Text = cyl_r_def;
            cyl_h_input.Text = cyl_h_def;

            light_X_input.Text = light_X_def;
            light_Y_input.Text = light_Y_def;
            light_Z_input.Text = light_Z_def;

            // Create temporary new bitmap to store blank image
            int c_width = pictureBox1.Width;
            int c_height = pictureBox1.Height;
            Bitmap bm2 = new Bitmap(c_width, c_height);

            // Create blank image
            using (Graphics g = Graphics.FromImage(bm2))
            {
                g.Clear(Color.White);
            }

            // Draw image to canvas
            pictureBox1.Image = bm2;
        }

        //******************************************************************************************************
        // AUTO-GENERATED FUNCTIONS (IGNORE)
        //******************************************************************************************************
        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void RayTraceSphere_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

    }
}
