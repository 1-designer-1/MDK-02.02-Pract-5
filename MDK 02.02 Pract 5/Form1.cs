using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary1;

namespace MDK_02._02_Pract_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Class1 class1 = new Class1();
        private void button1_Click(object sender, EventArgs e)
        {
            int[,] mass = class1.RandomArray();
            int rows = mass.GetUpperBound(0) + 1;
            int columns = mass.Length / rows;
            dataGridView1.ColumnCount = columns;
            dataGridView1.RowCount = rows;
            try
            {
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        dataGridView1[j, i].Value = mass[i, j];
                    }
                }

                class1.IndexArrya(mass, out int rez, out int ind);

                textBox1.Text = rez.ToString();
                textBox2.Text = (++ind).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[,] mass = class1.RandomArray();
            int rows = mass.GetUpperBound(0) + 1;
            int columns = mass.Length / rows;
            dataGridView2.ColumnCount = columns;
            dataGridView2.RowCount = rows;
            try
            {
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        dataGridView2[j, i].Value = mass[i, j];
                    }
                }

                class1.IndexArrya(mass, out int rez, out int ind);

                textBox1.Text = rez.ToString();
                textBox2.Text = (++ind).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Выполнил: Серегин Денис \n" +
                "Группа: ИСП-41 \n" +
                "Задание: \n" +
                "Даны два двумерных массива натуральных элементов." +
                " Размер исходных массивов не превосходит 10х10 элементов." +
                " Для каждого из массивов указать номера столбцов, содержащих только кратные 5 или 7 элементы." +
                " Если таких столбцов в массиве нет, то вывести соответствующее сообщение." +
                " Проверку столбца на наличие указанных элементов оформить в виде процедуры с передачей в нее всех элементов текущего столбца.", "О программе", MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void удалитьВсеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

