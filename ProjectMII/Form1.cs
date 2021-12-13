using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectMII
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[,] matrixA =
            {
                { int.Parse(A11.Text), int.Parse(A12.Text), int.Parse(A13.Text), int.Parse(A14.Text), int.Parse(A15.Text), int.Parse(A16.Text), int.Parse(A17.Text) },
                { int.Parse(A21.Text), int.Parse(A22.Text), int.Parse(A23.Text), int.Parse(A24.Text), int.Parse(A25.Text), int.Parse(A26.Text), int.Parse(A27.Text) },
                { int.Parse(A31.Text), int.Parse(A32.Text), int.Parse(A33.Text), int.Parse(A34.Text), int.Parse(A35.Text), int.Parse(A36.Text), int.Parse(A37.Text) },
                { int.Parse(A41.Text), int.Parse(A42.Text), int.Parse(A43.Text), int.Parse(A44.Text), int.Parse(A45.Text), int.Parse(A46.Text), int.Parse(A47.Text) },
                { int.Parse(A51.Text), int.Parse(A52.Text), int.Parse(A53.Text), int.Parse(A54.Text), int.Parse(A55.Text), int.Parse(A56.Text), int.Parse(A57.Text) }
            };

            int[,] matrixB =
            {
                { int.Parse(B11.Text), int.Parse(B12.Text), int.Parse(B13.Text), int.Parse(B14.Text), int.Parse(B15.Text)},
                { int.Parse(B21.Text), int.Parse(B22.Text), int.Parse(B23.Text), int.Parse(B24.Text), int.Parse(B25.Text)},
                { int.Parse(B31.Text), int.Parse(B32.Text), int.Parse(B33.Text), int.Parse(B34.Text), int.Parse(B35.Text)},
                { int.Parse(B41.Text), int.Parse(B42.Text), int.Parse(B43.Text), int.Parse(B44.Text), int.Parse(B45.Text)}
            };

            for (int i = 0; i < matrixA.GetLength(0); i++)
                if (matrixA[i, 2] == 0)
                {
                    matrixA[i, 2] = 1;
                }

            for (int i = 0; i < matrixB.GetLength(0); i++)
                if (matrixB[i, 4] == 1)
                {
                    matrixB[i, 4] = 0;
                }

            A13.Text = matrixA[0, 2].ToString();
            A23.Text = matrixA[1, 2].ToString();
            A33.Text = matrixA[2, 2].ToString();
            A43.Text = matrixA[3, 2].ToString();
            A53.Text = matrixA[4, 2].ToString();

            B15.Text = matrixB[0, 4].ToString();
            B25.Text = matrixB[1, 4].ToString();
            B35.Text = matrixB[2, 4].ToString();
            B45.Text = matrixB[3, 4].ToString();
        }
    }
}
