using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Isomorphism {
    class AnalyzeGraph {

        //No tienen la misma cantidad de vértices
        //No tienen la misma cantidad de aristas
        //No concuerdan los grados de los vértices
        //No es posible determinar la función de isomorfismo

        public bool equalsGraphs(int n, int[,] graphOne, int[,] graphTwo, int cantVertex){
            bool equal = true;
            for (int i = 0; i < cantVertex; i++){
                if (graphOne[i, n] != graphTwo[i, n]){
                    equal = false;
                }
                if (graphOne[n, i] != graphTwo[n, i]){
                    equal = false;
                }
            }
            return equal;
        }

        public void swapVertices(int[,] graph, int start, int finish, int cantVertex){
            int aux = 0;
            for (int i = 0; i < cantVertex; i++){
                aux = graph[start, i];
                graph[start, i] = graph[finish, i];
                graph[finish, i] = aux;
            }

            for(int j = 0; j < cantVertex; j++){
                aux = graph[j, start];
                graph[j, start] = graph[j, finish];
                graph[j, finish] = aux;
            }
        }

        public bool isIsomorphic(int[,] graphOne, int[,] graphTwo, int cantVertex){
            bool isomorphic = true;
            for (int i = 0; i < cantVertex; i++){
                for (int j = 0; j < cantVertex; j++){
                    if (graphOne[i, j] != graphTwo[i, j]){
                        isomorphic = false;
                        i = cantVertex;
                        j = cantVertex;
                    }
                }
            }
            return isomorphic;
        }

        public void checkGraph(int[,] graphOne, int[,] graphTwo, int[,] graphTwoCopy, int cantVertex, int[] vertexTwo){
            for (int i = 0; i < cantVertex; i++){
                if (graphOne != graphTwo){
                    for (int j = 0; j < cantVertex; j++){
                        if (!(equalsGraphs(j, graphOne, graphTwo, cantVertex))){
                            for (int k = j; k < cantVertex; k++){
                                int auxiliar = 0;
                                try{
                                    while (graphOne[j, k] != graphTwo[j, k + auxiliar])
                                    {
                                        auxiliar++;
                                    }
                                    if (graphOne[j, k] != graphTwo[j, k])
                                    {
                                        swapVertices(graphTwo, k, k + auxiliar, cantVertex);
                                        int aux = vertexTwo[k];
                                        vertexTwo[k] = vertexTwo[k + auxiliar];
                                        vertexTwo[k + auxiliar] = aux;
                                    }
                                }catch (Exception){
                                    i = cantVertex;
                                    j = cantVertex;
                                    k = cantVertex;
                                    MessageBox.Show("¡Los grafos seleccionados no concuerdan los grados de los vértices, por favor seleccione" +
                                    " archivos distintos!", "Los grafos no son isomorfos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    Application.Restart();
                                    
                                }
                            }
                        }
                    }
                }
                if (isIsomorphic(graphOne, graphTwo, cantVertex)){
                    i = cantVertex;
                }else{
                    swapVertices(graphTwoCopy, 0, i, cantVertex);
                    graphTwo = (int[,])graphTwoCopy.Clone();
                }
            }
        }

        public String IsomorphismFunction(int cantVertex, int[] vertexTwo){
            String function = "{";
            for (int i = 0; i < cantVertex; i++){
                function += "(" + i + "," + vertexTwo[i] + "); "; 
            }
            function = function.Remove(function.Length - 2);
            function += "}"; 
            return function;
        }
    }
}
