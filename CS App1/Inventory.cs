using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CS_App1 {
    public class Inventory {
        private List<Guitar> guitars;

        public Inventory() {
            this.guitars = new List<Guitar>();
        }

        public void addGuitar(string serialNumber, double price, string builder, string model, string type, string backWood, string topWood) {
            Guitar guitar = new Guitar(serialNumber, price, builder, model, type, backWood, topWood);
            this.guitars.Add(guitar);
        }

        public Guitar getGuitar(string serialNumber) {
            for (int i = 0; i < this.guitars.Count; i++) {
                Guitar guitar = this.guitars[i];

                if (guitar.getSerialNumber().Equals(serialNumber)) {
                    return guitar;
                }
            }

            return null;
        }

        public Guitar search(Guitar searchGuitar) {
            for (int i = 0; i < this.guitars.Count; i++) {
                Guitar guitar = this.guitars[i];

                string builder = searchGuitar.getBuilder();
                if ((builder != null) && (!builder.Equals("") && (!builder.Equals(guitar.getBuilder())))) {
                    continue;
                }

                // TODO : compare each property of the guitar

                return guitar;
            }

            return null;
        }
    }
}
