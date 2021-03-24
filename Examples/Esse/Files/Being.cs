using System;

namespace Esse {
    public abstract class Being {
        public abstract string Name { get; }
        public DateTime BirthDate { get; }

        public Being(DateTime birthData) {
            BirthDate = birthData;
        }

    }
}
