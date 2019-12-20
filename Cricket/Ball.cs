using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cricket
{
    public class Ball
    {
        // Team India

        public int Over { get; set; }
        public int Extras { get; set; }
        public int SixCount { get; set; }
        public int FourCount { get; set; }
        public int BallPerOver { get; set; }
        public int No_Of_Wicket { get; set; }
        public int No_Of_NoBall { get; set; }
        public int No_Of_DotBall { get; set; }
        public int No_Of_WideBall { get; set; }
        public int No_Of_BallFaced { get; set; }
        public int No_Of_ScoredBall { get; set; }
        public string Bowler { get; set; }
        public string Batsmen1 { get; set; }
        public string Batsmen2 { get; set; }
        public double TotalScore { get; set; }
        public double TargetScore { get; set; }


        // Team Australia

        public int Aus_Extras { get; set; }
        public int Aus_SixCount { get; set; }
        public int Aus_FourCount { get; set; }
        public int Aus_BallPerOver { get; set; }
        public int Aus_No_Of_Wicket { get; set; }
        public int Aus_No_Of_NoBall { get; set; }
        public int Aus_No_Of_DotBall { get; set; }
        public int Aus_No_Of_WideBall { get; set; }
        public int Aus_No_Of_BallFaced { get; set; }
        public int Aus_No_Of_ScoredBall { get; set; }
        public string Aus_Bowler { get; set; }
        public string Aus_Batsmen1 { get; set; }
        public string Aus_Batsmen2 { get; set; }
        public double Aus_TotalScore { get; set; }
        public double RunsRequired { get; set; }
        public int RemainingBall { get; set; }
        
    }
}
