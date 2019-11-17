using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Isomorphism{
    public partial class HomeApplication : Form {

        //Variables globales
        AnalyzeGraph analizeGraph = new AnalyzeGraph();
        private Graph graphOne = new Graph();
        private Graph graphTwo = new Graph();
        private Graph graphTwoCopy = new Graph();
        private int[] vertex;


        public HomeApplication(){
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e){
            ptbGraphOne.Visible = false;
            ptbGraphTwo.Visible = false;
            btnAnalyze.Enabled = false;
        }

        private void btnFirst_Click(object sender, EventArgs e) {
            if (openFileDialog.ShowDialog() == DialogResult.OK){
                graphOne = ReadDocument(openFileDialog.FileName, 1);
            }

        }

        private void btnSecond_Click(object sender, EventArgs e){
            if (openFileDialogTwo.ShowDialog() == DialogResult.OK){
                graphTwo = ReadDocument(openFileDialogTwo.FileName,  2);
                graphTwoCopy = graphTwo;
            }
        }

        private Graph ReadDocument(String pathDocument, int code) {
            int iteration = 0;
            Graph genericGraph = new Graph();
            StreamReader streamReader = new StreamReader(pathDocument);
            while (streamReader.Peek() >= 0){
                String lineRead = streamReader.ReadLine();
                if (iteration == 0){
                    genericGraph.setCantVertex(Convert.ToInt32(lineRead));
                    iteration++;
                }else{
                    try{
                        String[] resultAnalyce = lineRead.Split(',');
                        genericGraph.setEdgeMatrix(Convert.ToInt32(resultAnalyce[0]), Convert.ToInt32(resultAnalyce[1]));
                        iteration++;
                        if (code == 1){
                            ptbGraphOne.Visible = true;
                        }else{
                            ptbGraphTwo.Visible = true;
                            vertex = new int[graphOne.getCantVertex()];
                            vectorVertex();
                            btnAnalyze.Enabled = true;
                        }
                    }catch(Exception){
                        MessageBox.Show("El archivo seleccionado no contiene el formato permitido, por favor intentalo " +
                            "de nuevo con un archivo distinto","Error en el formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        
                    }
                }
            }
            genericGraph.setCantEdge(iteration);
            streamReader.Close();
            return genericGraph;

        }

        private void vectorVertex(){
            for (int i = 0; i < graphOne.getCantVertex(); i++){
                this.vertex[i] = i;
            }
        }

        private void btnAnalyze_Click(object sender, EventArgs e){
            if (graphOne.getCantVertex() != graphTwo.getCantVertex()){
                MessageBox.Show("¡Los grafos seleccionados no tienen la misma cantidad de vértices, por favor seleccione" +
                    " archivos distintos!", "Los grafos no son isomorfos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Restart();
            }else if (graphOne.getCantEdge() != graphTwo.getCantEdge()){
                MessageBox.Show("¡Los grafos seleccionados no tienen la misma cantidad de aristas, por favor seleccione" +
                    " archivos distintos!", "Los grafos no son isomorfos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Restart();
            }else{
                vectorVertex();
                analizeGraph.checkGraph(graphOne.getMatrixGraph(), graphTwo.getMatrixGraph(),
                    graphTwoCopy.getMatrixGraph(), graphOne.getCantVertex(), vertex);
                if (analizeGraph.isIsomorphic(graphOne.getMatrixGraph(), graphTwo.getMatrixGraph(),
                    graphOne.getCantVertex())){
                    MessageBox.Show("Función de ismorfismo: " + analizeGraph.IsomorphismFunction(graphOne.getCantVertex(), vertex), "¡Los grafos son isomorfos!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Application.Restart();
                }
            }
        }
    }
}
