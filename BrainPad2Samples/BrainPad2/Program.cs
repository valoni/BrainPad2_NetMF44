using System;
using System.Text;
using System.Threading;
using Microsoft.SPOT;
using Microsoft.SPOT.Hardware;
using System.Diagnostics;

namespace BrainPad2
{
    public class Program
    {
        public static void Main()
        {
            //I2CScanner.ScanAddresses(10, 150);
            //Scanning...
            //Device on address: 28(0x1C) Accelerometer
            //Device on address: 60(0x3C) OledDisplay SSD1306 128 x 64 

            //Debug.GC(false);


            // testSSD1306();
            // testRGB();
            //while (true)
            //{
            //    testTemp();
            //    Thread.Sleep(1000);
            //}

            //testLightLevel();

             //   Thread.Sleep(Timeout.Infinite);
        }





        private static void testLightLevel()
        {
            using (var analogInput = new AnalogInput(Cpu.AnalogChannel.ANALOG_7))
            {
                analogInput.Scale = 100;

                for (; ; )
                {
                    double currentVal = analogInput.Read();
                    //int raw = analogInput.ReadRaw();
                    Debug.Print("Results: " + currentVal + " (" + analogInput.ReadRaw().ToString() + ")");
                    Thread.Sleep(500);
                }
            }
        }

        private static void testTemp()
        {

            int voltage = 3300;
            double Celsius = 0;
            double Farenheit = 0;

            using (var analogInput = new AnalogInput(Cpu.AnalogChannel.ANALOG_6))
            {

                double num = 0;
                for (int i = 0; i < 10; i++)
                {
                    num += analogInput.Read();
                }
                num /= 10;

                Celsius = (num * (double)voltage - 400) / 19.5;
                Farenheit = 1.8 * Celsius + 32;

                Debug.Print("Celsiuse = " + Celsius.ToString());
                Debug.Print("Farenheit = " + Farenheit.ToString());

               
            }
        }


        private static void testRGB()
        {
            OutputPort redLed = new OutputPort(BrainPadBP2.Pin.RedLed, true);
            OutputPort blueLed = new OutputPort(BrainPadBP2.Pin.BlueLed, true);
            OutputPort greenLed = new OutputPort(BrainPadBP2.Pin.GreenLed, true);


          while(true)
            {
                redLed.Write(true);
                Thread.Sleep(200);
                redLed.Write(false);

                blueLed.Write(true);
                Thread.Sleep(200);
                blueLed.Write(false);

                greenLed.Write(true);
                Thread.Sleep(200);
                greenLed.Write(false);
            }

        }


        private static void testSSD1306()
           {
            I2CDevice.Configuration conf = new I2CDevice.Configuration(BrainPadBP2.OledDisplay.Address, 400);
            SSD1306 oled = new SSD1306(new I2CDevice(conf), BrainPadBP2.OledDisplay.width, BrainPadBP2.OledDisplay.height);
            oled.Init();

            //two circles
            oled.DrawCircle(31, 31, 30);
            oled.DrawFilledCircle(97, 31, 30);

            oled.Display();
            Thread.Sleep(5000);
            oled.Clear();

            Debug.GC(true);

            //archery target
            oled.DrawFilledCircle(63, 31, 30);
            oled.DrawCircle(63, 31, 25, false);
            oled.DrawCircle(63, 31, 20, false);
            oled.DrawCircle(63, 31, 15, false);
            oled.DrawCircle(63, 31, 10, false);
            oled.DrawCircle(63, 31, 5, false);

            oled.Display();
            Thread.Sleep(5000);
            oled.Clear();

            Debug.GC(true);

            //invert 
            oled.SetInverseDisplay(true);
            Thread.Sleep(5000);
            oled.SetInverseDisplay(false);

            //rectangles 
            oled.DrawRectangle(5, 20, 40, 40);
            oled.DrawFilledRectangle(50, 20, 50, 40);

            oled.Display();
            Thread.Sleep(5000);
            oled.Clear();

            //rounded rect
            oled.DrawRoundRect(5, 20, 40, 40, 10);
            oled.DrawRoundFilledRect(50, 20, 50, 40, 10);

            oled.Display();
            Thread.Sleep(5000);
            oled.Clear();

            oled.StartScrollHorizontally(true, 0, 0xff);
            Thread.Sleep(5000);

            oled.StartScrollHorizontally(false, 0, 0xff);
            Thread.Sleep(5000);
            oled.StartScrollVerticallyHorizontally(true, 0, 0xff, 0x02);
            Thread.Sleep(5000);
            oled.StartScrollVerticallyHorizontally(true, 0, 0xff, 0x0A);
            Thread.Sleep(5000);
            oled.DeactivateScroll();

            oled.Clear();


            //triangle + lines
            oled.DrawLine(10, 10, oled.Width - 10, oled.Height - 10);
            oled.DrawTriangle(5, 20, 5, 60, 63, 60);

            oled.Display();
            Thread.Sleep(5000);
            oled.Clear();


            //text
            oled.DrawText(0, 0, "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray(), 1);

            oled.Display();
            Thread.Sleep(5000);
            oled.Clear();

            //text
            oled.DrawText(0, 0, "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray(), 2);

            oled.Display();
            Thread.Sleep(5000);
            oled.Clear();
            return;
        }
    }
}
