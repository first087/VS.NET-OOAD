﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_App1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btnFindGuitar_Click(object sender, EventArgs e) {
            Inventory inventory = new Inventory();

            initialInventory(inventory);

            Guitar myGuitarLikes = new Guitar(null, 0.0, "gibson", null, null, null, null);

            Guitar guitar = inventory.search(myGuitarLikes);

            if (guitar != null) {
                displayGuitarInfo(guitar);
            } else {
                displaySorryMessage(myGuitarLikes);
            }
        }

        private void initialInventory(Inventory inventory) {
            inventory.addGuitar("1", 1999.95, "Finder", "F1000", "Acoustic", "Indian Rosewood", "Indian Rosewood");
            inventory.addGuitar("2", 1499.95, "Gibson", "GA101", "Electric", "Maple", "Alder");
            inventory.addGuitar("3", 1799.00, "Ryan", "R1A01", "Acoustic", "Alder", "Indian Rosewood");
        }

        private void displayGuitarInfo(Guitar guitar) {
            string infoMsg = String.Format("Found guitar.\n\nSerialNo. {0}\nPrice {1}", guitar.getSerialNumber(), guitar.getPrice());
            MessageBox.Show(infoMsg);
        }

        private void displaySorryMessage(Guitar guitar) {
            string sorryMsg = String.Format("Not found guitar build from {0}.", guitar.getBuilder());
            MessageBox.Show(sorryMsg);
        }
    }
}
