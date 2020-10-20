using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MEMESDASAM
{
    public partial class Form1 : Form
    {
        OpenFileDialog abrirArquivo;
        string caminhoDoArquivo;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBoxCima_TextChanged(object sender, EventArgs e)
        {
            labelCima.Text = textBoxCima.Text;
        }

        private void textBoxBaixo_TextChanged(object sender, EventArgs e)
        {
            labelBaixo.Text = textBoxBaixo.Text;
        }

        private void buttonAbrir_Click(object sender, EventArgs e)
        {
            abrirArquivo = new OpenFileDialog();
            abrirArquivo.InitialDirectory = "c:\\";
            abrirArquivo.Filter = "Arquivos de Imagem (*.jpg, *.jpeg, *.jpe, *.jfif, *.png, *.svg)|*.jpg; *.jpeg; *.jpe; *.jfif; *.png; *.svg; *.gif; *bmp";
            abrirArquivo.FilterIndex = 2;
            abrirArquivo.RestoreDirectory = true;

            if (abrirArquivo.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureBox.Image = Image.FromFile(abrirArquivo.FileName);
                    caminhoDoArquivo = abrirArquivo.FileName;
                }
                catch (Exception excecao)
                {
                    MessageBox.Show("Não consegui ler este arquivo :c" + excecao.Message);
                    throw;
                }
            }
        }

        private void buttonPreto_Click(object sender, EventArgs e)
        {
            labelCima.ForeColor = SystemColors.ActiveCaptionText;
            labelBaixo.ForeColor = SystemColors.ActiveCaptionText;
        }

        private void buttonBranco_Click(object sender, EventArgs e)
        {
            labelCima.ForeColor = SystemColors.ButtonHighlight;
            labelBaixo.ForeColor = SystemColors.ButtonHighlight;
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            string primeiroTexto = labelCima.Text;
            string segundoTexto = labelBaixo.Text;

            Bitmap imagemFinal = (Bitmap) Image.FromFile(caminhoDoArquivo);

            RectangleF localTextoCima = new RectangleF((imagemFinal.Width / 2) - (labelCima.Width / 2), 20, imagemFinal.Width, 400);
            RectangleF localTextoBaixo = new RectangleF((imagemFinal.Width / 2) - (labelCima.Width / 2), imagemFinal.Height - 100, imagemFinal.Width, 400);

            SaveFileDialog salvarImagem = new SaveFileDialog();
            salvarImagem.FileName = "*";
            salvarImagem.DefaultExt = "bmp";
            salvarImagem.ValidateNames = true;
            salvarImagem.Filter = "Imagem Bitmap | *.bmp | Imagem GIF | *.gif | Imagem JPEG | *.jpg | Imagem PNG | *png";

            if (salvarImagem.ShowDialog() == DialogResult.OK)
            {
                using (Graphics desenhista = Graphics.FromImage(imagemFinal))
                {
                    using (Font fonteDoMeme = new Font("Comic Sans MS", 30, FontStyle.Bold, GraphicsUnit.Point))
                    {
                        if (labelCima.ForeColor == SystemColors.ButtonHighlight || labelCima.ForeColor != SystemColors.ActiveCaptionText)
                        {
                            desenhista.DrawString(primeiroTexto, fonteDoMeme, Brushes.White, localTextoCima);
                            desenhista.DrawString(segundoTexto, fonteDoMeme, Brushes.White, localTextoBaixo);
                        }
                        else
                        {
                            desenhista.DrawString(primeiroTexto, fonteDoMeme, Brushes.Black, localTextoCima);
                            desenhista.DrawString(segundoTexto, fonteDoMeme, Brushes.Black, localTextoBaixo);
                        }
                    }
                }
                imagemFinal.Save(salvarImagem.FileName);
            }
            
        }
    }
}
