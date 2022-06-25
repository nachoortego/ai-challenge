using Core.Games;
using Core.Player;
using Core.Utils;
using UnityEngine;

namespace Teams.the_GOBSTONKS
{
    public class PlayerOne : TeamPlayer
    {
        public override void OnUpdate()
        {
            GoTo(FieldPosition.D3);
        }

        public override void OnReachBall()
        {
            
        }

        public override void OnScoreBoardChanged(ScoreBoard scoreBoard)
        {

        }

        public override FieldPosition GetInitialPosition() => FieldPosition.A2;

        public override string GetPlayerDisplayName() => "Player 1";
    }
}