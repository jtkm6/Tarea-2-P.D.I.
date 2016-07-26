using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace PDI_Tarea_2 {

	class ImageManipulation {
		// Data to work.
		private Label fileName, fileSize, fileDimentions, bitsProfundidad;
		private Bitmap originalImageFile, resultImageFile;
		private String filePatch;
		private Chart histogram;

		// Image, modifications data.
		protected int brilloEnLaImagen = 0, umbralThreshold = 127;
		protected float anguloARotar = 0.0f, escalaAInterpolar = 1.0f, contrasteEnLaImagen = 1.0f;
		protected bool flipVertical = false, flipHorizontal = false, invertirColores = false, ecualizarImagen = false, umbralizar = false;
		protected int[] ColorR, ColorG, ColorB, colorDataR, colorDataG, colorDataB;

		public ImageManipulation(Chart Histogram, Label fileName, Label fileSize, Label fileDimentions, Label bitsProfundidad) {
			this.fileName = fileName; this.fileSize = fileSize; this.fileDimentions = fileDimentions; this.bitsProfundidad = bitsProfundidad;
			histogram = Histogram;
			ColorR = new int[256];
			ColorG = new int[256];
			ColorB = new int[256];
			colorDataR = new int[256];
			colorDataG = new int[256];
			colorDataB = new int[256];
		}

		private int clamp(float value) {
			return (int)Math.Max(0.0f, Math.Min(255.0f, value));
		}

		private Bitmap rotateImageFunction(Bitmap IN, float angle) {
			double radAngle = Math.Max(-angle, angle) * (float)Math.PI / 180.0f;
			double Cos = Math.Abs(Math.Cos(radAngle));
			double Sin = Math.Abs(Math.Sin(radAngle));
			int newWidth = (int)(IN.Width * Cos + IN.Height * Sin);
			int newHeight = (int)(IN.Width * Sin + IN.Height * Cos);
			Bitmap OUT = new Bitmap(newWidth, newHeight);
			Graphics gaphics = Graphics.FromImage(OUT);
			gaphics.TranslateTransform((float)(newWidth - IN.Width) / 2, (float)(newHeight - IN.Height) / 2);
			gaphics.TranslateTransform((float)IN.Width / 2, (float)IN.Height / 2);
			gaphics.RotateTransform(Math.Max(-angle, angle));
			gaphics.TranslateTransform(-(float)IN.Width / 2, -(float)IN.Height / 2);
			gaphics.DrawImage(IN, new Point(0, 0));
			gaphics.Dispose();
			return OUT;
		}

		private Bitmap scalateImageFunction(Bitmap IN, float percent) {
			Bitmap OUT = new Bitmap((int)(IN.Width * percent), (int)(IN.Height * percent));
			double Xratio = (double)IN.Width / (double)OUT.Width;
			double Yratio = (double)IN.Height / (double)OUT.Height;
			for(int Y = 0; Y < OUT.Height; ++Y) {
				for(int X = 0; X < OUT.Width; ++X) {
					double newX = Math.Floor(X * Xratio);
					double newY = Math.Floor(Y * Yratio);
					OUT.SetPixel(X, Y, IN.GetPixel((int)newX, (int)newY));
				}
			}
			return OUT;
		}

		public void loadFile(String Patch) {
			this.filePatch = Patch;

			originalImageFile = (Bitmap)Image.FromFile(filePatch);
			fileName.Text = Path.GetFileName(Patch);
			fileSize.Text = ((int)((new FileInfo(Patch)).Length / 1000)).ToString() + " KB";
		}

		public void saveImagen(String patch = null) {
			if(patch == null) {
				String extension = Path.GetExtension(filePatch);
				System.Drawing.Imaging.ImageFormat Formato;
				switch(extension.ToLower()) {
					case ".png":
					Formato = System.Drawing.Imaging.ImageFormat.Png;
					break;
					case ".gif":
					Formato = System.Drawing.Imaging.ImageFormat.Gif;
					break;
					case ".tiff":
					Formato = System.Drawing.Imaging.ImageFormat.Tiff;
					break;
					case ".bmp":
					Formato = System.Drawing.Imaging.ImageFormat.Bmp;
					break;
					case ".jpg":
					Formato = System.Drawing.Imaging.ImageFormat.Jpeg;
					break;
					default:
					Formato = System.Drawing.Imaging.ImageFormat.Bmp;
					break;
				}
				originalImageFile.Dispose();
				originalImageFile = (Bitmap) resultImageFile.Clone();
				originalImageFile.Save(filePatch);
			} else {
				String extension = Path.GetExtension(patch);
				System.Drawing.Imaging.ImageFormat Formato;
				switch(extension.ToLower()) {
					case ".png":
					Formato = System.Drawing.Imaging.ImageFormat.Png;
					break;
					case ".gif":
					Formato = System.Drawing.Imaging.ImageFormat.Gif;
					break;
					case ".tiff":
					Formato = System.Drawing.Imaging.ImageFormat.Tiff;
					break;
					case ".bmp":
					Formato = System.Drawing.Imaging.ImageFormat.Bmp;
					break;
					case ".jpg":
					Formato = System.Drawing.Imaging.ImageFormat.Jpeg;
					break;
					default:
					Formato = System.Drawing.Imaging.ImageFormat.Bmp;
					break;
				}
				resultImageFile.Save(patch, Formato);
			}
		}

		public Bitmap getActualImage() {
			if(resultImageFile != null)
				resultImageFile.Dispose();
			Bitmap temp;
			temp = scalateImageFunction(originalImageFile, escalaAInterpolar);
			resultImageFile = rotateImageFunction(temp, anguloARotar);
			temp.Dispose();
			//
			if(flipHorizontal) {
				for(int y = 0; y < resultImageFile.Height; ++y) {
					for(int x = 0; x < resultImageFile.Width / 2; ++x) {
						Color A = resultImageFile.GetPixel(x, y), B = resultImageFile.GetPixel((resultImageFile.Width - 1) - x, y);
						resultImageFile.SetPixel(x, y, B); resultImageFile.SetPixel((resultImageFile.Width - 1) - x, y, A);
					}
				}
			}
			if(flipVertical) {
				for(int y = 0; y < resultImageFile.Height / 2; ++y) {
					for(int x = 0; x < resultImageFile.Width; ++x) {
						Color A = resultImageFile.GetPixel(x, y), B = resultImageFile.GetPixel(x, (resultImageFile.Height - 1) - y);
						resultImageFile.SetPixel(x, y, B); resultImageFile.SetPixel(x, (resultImageFile.Height - 1) - y, A);
					}
				}
			}
			if(invertirColores) {
				for(int y = 0; y < resultImageFile.Height; ++y) {
					for(int x = 0; x < resultImageFile.Width; ++x) {
						Color A = resultImageFile.GetPixel(x, y);
						resultImageFile.SetPixel(x, y, Color.FromArgb(A.A, 255 - A.R, 255 - A.G, 255 - A.B));
					}
				}
			}
			for(int i = 0; i < resultImageFile.Height; ++i) {
				for(int j = 0; j < resultImageFile.Width; ++j) {
					Color pixel = resultImageFile.GetPixel(j, i);
					int R = clamp(brilloEnLaImagen + (int)(contrasteEnLaImagen * pixel.R));
					int G = clamp(brilloEnLaImagen + (int)(contrasteEnLaImagen * pixel.G));
					int B = clamp(brilloEnLaImagen + (int)(contrasteEnLaImagen * pixel.B));
					pixel = Color.FromArgb(pixel.A, R, G, B);
					resultImageFile.SetPixel(j, i, pixel);
					++ColorR[R]; ++ColorG[G]; ++ColorB[B];
				}
			}
			if(ecualizarImagen) {
				int RAcum = ColorR[0], GAcum = ColorG[0], BAcum = ColorB[0], totalOfPixels = resultImageFile.Width * resultImageFile.Height;
				colorDataR[0] = 0; colorDataG[0] = 0; colorDataB[0] = 0;
				for(int i = 1; i < 255; ++i) {
					colorDataR[i] = RAcum * 255 / totalOfPixels;
					colorDataG[i] = GAcum * 255 / totalOfPixels;
					colorDataB[i] = BAcum * 255 / totalOfPixels;
					RAcum += ColorR[i]; GAcum += ColorG[i]; BAcum += ColorB[i];
					ColorR[i] = ColorG[i] = ColorB[i] = 0;
				}
				colorDataR[255] = 255; colorDataG[255] = 255; colorDataB[255] = 255;
				for(int i = 0; i < resultImageFile.Height; ++i) {
					for(int j = 0; j < resultImageFile.Width; ++j) {
						Color pixel = resultImageFile.GetPixel(j, i);
						int R = clamp(brilloEnLaImagen + (int)(contrasteEnLaImagen * colorDataR[pixel.R]));
						int G = clamp(brilloEnLaImagen + (int)(contrasteEnLaImagen * colorDataG[pixel.G]));
						int B = clamp(brilloEnLaImagen + (int)(contrasteEnLaImagen * colorDataB[pixel.B]));
						pixel = Color.FromArgb(pixel.A, R, G, B);
						resultImageFile.SetPixel(j, i, pixel);
						++ColorR[R]; ++ColorG[G]; ++ColorB[B];
					}
				}
			}
			foreach(var series in histogram.Series) {
				series.Points.Clear();
			}
			for(int i = 0; i < 256; ++i) {
				histogram.Series[0].Points.AddXY(i, ColorR[i]);
				histogram.Series[1].Points.AddXY(i, ColorG[i]);
				histogram.Series[2].Points.AddXY(i, ColorB[i]);
				ColorR[i] = ColorG[i] = ColorB[i] = 0;
			}
			if(umbralizar) {
				for(int i = 0; i < resultImageFile.Height; ++i) {
					for(int j = 0; j < resultImageFile.Width; ++j) {
						Color pixel = resultImageFile.GetPixel(j, i);
						int U = ((pixel.R + pixel.G + pixel.B) / 3) > umbralThreshold ? 255 : 0;
						pixel = Color.FromArgb(pixel.A, U, U, U);
						resultImageFile.SetPixel(j, i, pixel);
					}
				}
			}
			//
			fileDimentions.Text = resultImageFile.Width.ToString() + " X " + resultImageFile.Height.ToString() + "px";
			bitsProfundidad.Text = resultImageFile.PixelFormat.ToString();
			return resultImageFile;
		}

		public void setRotationAngle(int angle) {
			anguloARotar = (float)angle;
		}

		public void setZoomProportion(bool Out) {
			escalaAInterpolar += Out ? -0.01f : 0.01f;
			escalaAInterpolar = (escalaAInterpolar < 0) ? 0 : escalaAInterpolar;
		}

		public void setFlipVertical() {
			flipVertical = !flipVertical;
		}

		public void setFlipHorizontal() {
			flipHorizontal = !flipHorizontal;
		}

		public void setInvertirColores() {
			invertirColores = !invertirColores;
		}

		public void setBrillo(int brillo) {
			brilloEnLaImagen = brillo;
		}

		public void setContraste(int contraste) {
			contrasteEnLaImagen = ((float)contraste / 300.0f) + 1.0f;
		}

		public void setEcualizateImage() {
			ecualizarImagen = !ecualizarImagen;
		}

		public void setUmbralizar() {
			umbralizar = !umbralizar;
		}

		public void setUmbralThreshold(int threshold) {
			umbralThreshold = threshold;
		}

		public bool imageIsOpen() {
			return originalImageFile != null;
		}
	}
}
