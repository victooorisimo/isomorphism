using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Isomorphism {

    class Graph {
        //Class attributes
        private int cantVertex;
        private int cantEdge;
        private int[,] matrixGraph;

        //Class methods
        //Constructor class
        public Graph(){
            cantVertex = 0;
        }

        //Getters and setters methods
        public void setCantVertex(int cantVertex) {
            this.cantVertex = cantVertex;
            matrixGraph = new int[cantVertex, cantVertex];
        }

        public int getCantVertex(){
            return cantVertex;
        }

        public void setCantEdge(int cantEdge){
            this.cantEdge = cantEdge;
        }

        public int getCantEdge(){
            return cantEdge;
        }

        public void setEdgeMatrix(int coordX, int coordY){
            this.matrixGraph[coordX, coordY] = 1;
        }

        public int[,] getMatrixGraph(){
            return matrixGraph;
        }

    }
}
