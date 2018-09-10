using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

//**************************************************************************************************************
//Project :    GymWorkout First Project
//Description: Webform to display Gym Workout vidoes and instructions by selecting the muscle group hotspots.
//             Using ASP.net Web Forms, Css, Animated.css plugin
//Author:      Kevin Chan
//Date:        June, 2018
//***************************************************************************************************************

namespace GymWorkout
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void ImageMap1_Click(object sender, ImageMapEventArgs e)
        {
            string instructions = "";
            string uTube = "";
            //pnlTextMap.Controls.Add(new LiteralControl(instructions));
            //pnlImageMap.Controls.Add(new LiteralControl(uTube));
            //selected muscle group to display video and instructions
            switch (e.PostBackValue)
            {
                case "rB":
                case "lB":
                    instructions = "<p>1. Stand up straight with a dumbbell in each hand at arm's length. Keep your elbows close to your torso and rotate the palms of your hands until they are facing forward. This will be your starting position.</p><p> 2.Now, keeping the upper arms stationary, exhale and curl the weights while contracting your biceps. Continue to raise the weights until your biceps are fully contracted and the dumbbells are at shoulder level. Hold the contracted position for a brief pause as you squeeze your biceps.</p>"
                        + "<p> 3.Then, inhale and slowly begin to lower the dumbbells back to the starting position.</p>"
                        + "<p> 4.Repeat for the recommended amount of repetitions.</p>";
                    pnlTextMap.Controls.Add(new LiteralControl(instructions));
                    uTube = "<iframe width = \"362\" height = \"244\" src = \"https://www.youtube.com/embed/eqY5z3svnUw\" frameborder = \"0\" allow = \"autoplay; encrypted-media\" allowfullscreen ></iframe >";
                    pnlImageMap.Controls.Add(new LiteralControl(uTube));
                    break;
                case "lC":
                case "rC":
                    instructions = "<p>1. Lie down on your back on the bench and grab one dumbbell with each hand at body height, elbows just slightly arched.</p>"
                        + "<p>2. Raise the dumbbells until they are side by side on top of you and slowly lower them back after a short pause.</p>"
                        + "<p>3. Try to maintain the same angle in your elbows throughout.</p>";
                    pnlTextMap.Controls.Add(new LiteralControl(instructions));
                    uTube = "<iframe width=\"362\" height=\"244\" src=\"https://www.youtube.com/embed/eozdVDA78K0\" frameborder=\"0\" allow=\"autoplay; encrypted-media\" allowfullscreen></iframe>";
                    pnlImageMap.Controls.Add(new LiteralControl(uTube));
                    break;
                case "aB":
                    instructions = "<p>1. Lie faceup on the ball, with ball under low back, feet on floor hip-width apart, and hands behind ears.</p>"
                        + "<p>2. Brace core, tighten glutes, and slowly crunch upper body upward, raising shoulders off ball and tucking chin to chest. </p>"
                        + "<p>3. Slowly lower upper body down to return to start. And repeat Reps</p>";
                    pnlTextMap.Controls.Add(new LiteralControl(instructions));
                    uTube = "<iframe width=\"362\" height=\"244\" src=\"https://www.youtube.com/embed/Imui46JTe7s\" frameborder=\"0\" allow=\"autoplay; encrypted-media\" allowfullscreen></iframe>";
                    pnlImageMap.Controls.Add(new LiteralControl(uTube));
                    break;
                case "lQ":
                case "rQ":
                    instructions = "<p>1. Hold on to the bar using both arms and load bar on your shoulders.</p>"
                        + "<p>2. Step away from the rack and position your legs using a shoulder-width medium stance with the toes slightly pointed out. Keep your head up at all times and maintain a straight back. </p>"
                        + "<p>3. Begin to slowly lower the bar by bending the knees and sitting back with your hips as you maintain a straight posture with the head up. Continue down until your hamstrings are on your calves. Inhale as you perform this portion of the movement.</p>"
                        + "<p>4. Begin to raise the bar as you exhale by pushing the floor with the heel or middle of your foot as you straighten the legs and extend the hips to go back to the starting position. Repeat Reps</p>";
                    pnlTextMap.Controls.Add(new LiteralControl(instructions));
                    uTube = "<iframe width=\"362\" height=\"244\" src=\"https://www.youtube.com/embed/SW_C1A-rejs\" frameborder=\"0\" allow=\"autoplay; encrypted-media\" allowfullscreen></iframe>";
                    pnlImageMap.Controls.Add(new LiteralControl(uTube));
                    break;


                default:
                    //instructions = "Reset";
                    //pnlTextMap.Controls.Add(new LiteralControl(instructions));
                    //uTube = "";
                    //IsPostBack = false;
                    //pnlTextMap.Controls.Remove();
                    // Response.Redirect(Request.Url.AbsoluteUri);
                    //pnlTextMap.Visible = false;
                    //pnlImageMap.Controls.Add(new LiteralControl(uTube));
                    

                    break;
            }
        }
    }
}