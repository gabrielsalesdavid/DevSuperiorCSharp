using System;
using System.Globalization;

namespace Worker.entities {
    class Department {

        public string Name {  get; set; }

        public Department() {
        }

        public Department(string name) {

            this.Name = name;
        }
    }
}