using System;

namespace Esse {
    public class CowardBeing : Being, Taxonomy.Kingdom.IAnimalia, Taxonomy.Class.IReptile, IAppendageBeing {
        public override string Name => "Coward";
        public Scale Scale { get; }
        public Appendage[] Appendages { get; }

        public CowardBeing(DateTime birthDate) : base(birthDate) {
            Scale = Scale.Default;
            Appendages = new Appendage[4] {
                Appendage.Default,
                Appendage.Default,
                Appendage.Default,
                Appendage.Default
            };
        }

    }
}
