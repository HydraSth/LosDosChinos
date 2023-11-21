using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;

namespace TP2_LosDosChinos_JuanCruzEspasandin
{
    public partial class Camaras : Form
    {
        private FilterInfoCollection videoDevices;
        private VideoCaptureDevice videoSource;

        public Camaras()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Obtener la lista de dispositivos de video disponibles
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            if (videoDevices.Count > 0)
            {
                // Poblar el ComboBox con la lista de cámaras
                foreach (FilterInfo device in videoDevices)
                {
                    CB_Camaras.Items.Add(device.Name);
                }

                // Seleccionar la primera cámara por defecto
                CB_Camaras.SelectedIndex = 0;

                // Usar el primer dispositivo de video encontrado
                videoSource = new VideoCaptureDevice(videoDevices[0].MonikerString);
                videoSource.NewFrame += VideoSource_NewFrame;

                // Iniciar la captura de video
                videoSource.Start();
            }
            else
            {
                Console.WriteLine("No se encontraron cámaras disponibles.");
            }
        }

        private void VideoSource_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            // Actualizar la vista previa en el PictureBox
            pictureBoxVideo.Image = (System.Drawing.Image)eventArgs.Frame.Clone();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Detener la captura de video al cerrar la aplicación
            if (videoSource != null && videoSource.IsRunning)
            {
                videoSource.SignalToStop();
                videoSource.WaitForStop();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Desactivar las cámaras cuando se hace clic en el botón
            StopVideoSource();
        }

        private void StopVideoSource()
        {
            // Detener la captura de video si está en ejecución
            if (videoSource != null && videoSource.IsRunning)
            {
                videoSource.SignalToStop();
                videoSource.WaitForStop();
                pictureBoxVideo.Image = null;
            }
            else
            {
                // Iniciar la captura de video si no está en ejecución
                if (videoDevices.Count > 0)
                {
                    videoSource = new VideoCaptureDevice(videoDevices[0].MonikerString);
                    videoSource.NewFrame += VideoSource_NewFrame;

                    videoSource.Start();
                }
                else
                {
                    Console.WriteLine("No se encontraron cámaras disponibles.");
                }
            }
        }
    }
}