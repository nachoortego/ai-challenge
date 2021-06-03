using Core.Games;
using Core.Player;
using Core.Utils;
using UnityEngine;

namespace Teams.my_team
{
    public class Offensive : TeamPlayer
    {
        public override void OnUpdate()
        {
            MoveBy(GetDirectionTo(GetBallPosition()));
            Debug.Log("Ball pos:" + GetBallPosition().ToString());
            Debug.Log("My   pos:" + GetPosition().ToString());
            Debug.Log("Direction to ball:" + GetDirectionTo(GetBallPosition()));   
            Debug.Log("estoy vivo");
        }

        public override void OnReachBall()
        {
	        ShootBall(GetDirectionTo(GetTeamMatesInformation()[1].Position),ShootForce.High);
	        Debug.DrawLine(GetTeamMatesInformation()[1].Position, GetPosition(), Color.magenta, 0.5f);
        }

        public override void OnScoreBoardChanged(ScoreBoard scoreBoard)
        {
        }

        public override FieldPosition GetInitialPosition() => FieldPosition.A3;

        public override string GetPlayerDisplayName() => "Turing";
    }
}