using Core.Games;
using Core.Player;
using JetBrains.Annotations;
using UnityEngine;

namespace Teams.the_GOBSTONKS
{
    [UsedImplicitly]
    public class ExampleTeam : Team
    {
        public TargetPreference PenaltyDivePreference { get; } = new TargetPreference(3,1,4);

        public TargetPreference PenaltyKickPreference { get; } = new TargetPreference(2,1,2);
        
        public TeamPlayer GetPlayerOne() => new PlayerOne();

        public TeamPlayer GetPlayerTwo() => new PlayerTwo();

        public TeamPlayer GetPlayerThree() => new PlayerThree();
        
        public Color PrimaryColor => new Color(0.51f, 0.6f, 1.0f);

        public string GetName() => "the GOBSTONKS";

        public string TeamShield => "Blue";
    }
}