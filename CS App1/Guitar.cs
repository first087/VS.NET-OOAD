using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CS_App1 {
    public class Guitar {
        private string serialNumber;
        private double price;
        private string builder;
        private string model;
        private string type;
        private string backWood;
        private string topWood;

        public Guitar(string serialNumber, double price, string builder, string model, string type, string backWood, string topWood) {
            this.serialNumber = serialNumber;
            this.price = price;
            this.builder = builder;
            this.model = model;
            this.type = type;
            this.backWood = backWood;
            this.topWood = topWood;
        }

        public string getSerialNumber() {
            return this.serialNumber;
        }

        public double getPrice() {
            return this.price;
        }

        public void setPrice(float price) {
            this.price = price;
        }

        public string getBuilder() {
            return this.builder;
        }

        public string getModel() {
            return this.model;
        }

        public string getType() {
            return this.type;
        }

        public string getBackWood() {
            return this.backWood;
        }

        public string getTopWood() {
            return this.topWood;
        }
    }
}
