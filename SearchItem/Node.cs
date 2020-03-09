using System;
using System.Collections.Generic;
using System.Text;

namespace EstructurasDeDatos.ListaEnlazada {
    public class Node {
        private int value;
        private Node next;

        public int Value {
            get {
                return this.value;
            }
        }
        public Node Next {
            get {
                return this.next;
            }
            set {
                this.next = value;
            }
        }

        public Node(int value) {
            this.value = value;
            this.next = null;
        }
        public Node(int value, Node next) {
            this.value = value;
            this.next = next;
        }
    }
}
