using System;
using System.IO.Ports;
using Microsoft.SPOT.Hardware;

namespace BrainPad2
{
    public static class BrainPadBP2
    {
        public class Pin
        {
            /// <summary>A value indicating that no GPIO pin is specified.</summary>
            public const Cpu.Pin GPIO_NONE = Cpu.Pin.GPIO_NONE;

            /// <summary>Digital I/O.</summary>
            public const Cpu.Pin PA0 = (Cpu.Pin)((0 * 16) + 0);  // Analog0

            /// <summary>Digital I/O.</summary>
            public const Cpu.Pin PA1 = (Cpu.Pin)((0 * 16) + 1); // Analog1

            /// <summary>Digital I/O.</summary>
            public const Cpu.Pin PA2 = (Cpu.Pin)((0 * 16) + 2); // Analog2

            /// <summary>Digital I/O.</summary>
            public const Cpu.Pin PA3 = (Cpu.Pin)((0 * 16) + 3);

            /// <summary>Digital I/O.</summary>
            public const Cpu.Pin PA4 = (Cpu.Pin)((0 * 16) + 4); // Analog3

            /// <summary>Digital I/O.</summary>
            public const Cpu.Pin PA5 = (Cpu.Pin)((0 * 16) + 5);  //sclk1

            /// <summary>Digital I/O.</summary>
            public const Cpu.Pin PA6 = (Cpu.Pin)((0 * 16) + 6);  //miso1

            /// <summary>Digital I/O.</summary>
            public const Cpu.Pin PA7 = (Cpu.Pin)((0 * 16) + 7); //pw7 //mosi1

            /// <summary>Digital I/O.</summary>
            public const Cpu.Pin PA8 = (Cpu.Pin)((0 * 16) + 8);

            /// <summary>Digital I/O.</summary>
            public const Cpu.Pin PA9 = (Cpu.Pin)((0 * 16) + 9);

            /// <summary>Digital I/O.</summary>
            public const Cpu.Pin PA10 = (Cpu.Pin)((0 * 16) + 10);

            /// <summary>Digital I/O.</summary>
            public const Cpu.Pin PA11 = (Cpu.Pin)((0 * 16) + 11);

            /// <summary>Digital I/O.</summary>
            public const Cpu.Pin PA12 = (Cpu.Pin)((0 * 16) + 12);

            /// <summary>Digital I/O.</summary>
            public const Cpu.Pin PA13 = (Cpu.Pin)((0 * 16) + 13);

            /// <summary>Digital I/O.</summary>
            public const Cpu.Pin PA14 = (Cpu.Pin)((0 * 16) + 14);

            /// <summary>Digital I/O.</summary>
            public const Cpu.Pin PA15 = (Cpu.Pin)((0 * 16) + 15);


            /// <summary>Digital I/O.</summary>
            public const Cpu.Pin PB0 = (Cpu.Pin)((1 * 16) + 0);  //pwm1 // Analog4

            /// <summary>Digital I/O.</summary>
            public const Cpu.Pin PB1 = (Cpu.Pin)((1 * 16) + 1);  //pwm2 // Analog5

            /// <summary>Digital I/O.</summary>
            public const Cpu.Pin PB2 = (Cpu.Pin)((1 * 16) + 2);

            /// <summary>Digital I/O.</summary>
            public const Cpu.Pin PB3 = (Cpu.Pin)((1 * 16) + 3);

            /// <summary>Digital I/O.</summary>
            public const Cpu.Pin PB4 = (Cpu.Pin)((1 * 16) + 4);  //pw3

            /// <summary>Digital I/O.</summary>
            public const Cpu.Pin PB5 = (Cpu.Pin)((1 * 16) + 5);

            /// <summary>Digital I/O.</summary>
            public const Cpu.Pin PB6 = (Cpu.Pin)((1 * 16) + 6); //pw4

            /// <summary>Digital I/O.</summary>
            public const Cpu.Pin PB7 = (Cpu.Pin)((1 * 16) + 7);

            /// <summary>Digital I/O.</summary>
            public const Cpu.Pin PB8 = (Cpu.Pin)((1 * 16) + 8); //pw5 //scl

            /// <summary>Digital I/O.</summary>
            public const Cpu.Pin PB9 = (Cpu.Pin)((1 * 16) + 9); //pw6 //sda

            /// <summary>Digital I/O.</summary>
            public const Cpu.Pin PB10 = (Cpu.Pin)((1 * 16) + 10);

            /// <summary>Digital I/O.</summary>
            public const Cpu.Pin PB11 = (Cpu.Pin)((1 * 16) + 11);

            /// <summary>Digital I/O.</summary>
            public const Cpu.Pin PB12 = (Cpu.Pin)((1 * 16) + 12);

            /// <summary>Digital I/O.</summary>
            public const Cpu.Pin PB13 = (Cpu.Pin)((1 * 16) + 13);  //mosi2

            /// <summary>Digital I/O.</summary>
            public const Cpu.Pin PB14 = (Cpu.Pin)((1 * 16) + 14);  //miso2

            /// <summary>Digital I/O.</summary> 
            public const Cpu.Pin PB15 = (Cpu.Pin)((1 * 16) + 15);  //sclk2



            /// <summary>Digital I/O.</summary>
            public const Cpu.Pin PC0 = (Cpu.Pin)((2 * 16) + 0);  // Analog6

            /// <summary>Digital I/O.</summary>
            public const Cpu.Pin PC1 = (Cpu.Pin)((2 * 16) + 1); // Analog7

            /// <summary>Digital I/O.</summary>
            public const Cpu.Pin PC2 = (Cpu.Pin)((2 * 16) + 2); // Analog8

            /// <summary>Digital I/O.</summary>
            public const Cpu.Pin PC3 = (Cpu.Pin)((2 * 16) + 3); // Analog9

            /// <summary>Digital I/O.</summary>
            public const Cpu.Pin PC4 = (Cpu.Pin)((2 * 16) + 4);

            /// <summary>Digital I/O.</summary>
            public const Cpu.Pin PC5 = (Cpu.Pin)((2 * 16) + 5);

            /// <summary>Digital I/O.</summary>
            public const Cpu.Pin PC6 = (Cpu.Pin)((2 * 16) + 6);

            /// <summary>Digital I/O.</summary>
            public const Cpu.Pin PC7 = (Cpu.Pin)((2 * 16) + 7);

            /// <summary>Digital I/O.</summary>
            public const Cpu.Pin PC8 = (Cpu.Pin)((2 * 16) + 8);

            /// <summary>Digital I/O.</summary>
            public const Cpu.Pin PC9 = (Cpu.Pin)((2 * 16) + 9);

            /// <summary>Digital I/O.</summary>
            public const Cpu.Pin PC10 = (Cpu.Pin)((2 * 16) + 10);

            /// <summary>Digital I/O.</summary>
            public const Cpu.Pin PC11 = (Cpu.Pin)((2 * 16) + 11);

            /// <summary>Digital I/O.</summary>
            public const Cpu.Pin PC12 = (Cpu.Pin)((2 * 16) + 12);

            /// <summary>Digital I/O.</summary>
            public const Cpu.Pin PC13 = (Cpu.Pin)((2 * 16) + 13);

            /// <summary>Digital I/O.</summary>
            public const Cpu.Pin PC14 = (Cpu.Pin)((2 * 16) + 14);

            /// <summary>Digital I/O.</summary>
            public const Cpu.Pin PC15 = (Cpu.Pin)((2 * 16) + 15);

            /// <summary>Digital I/O.</summary>
            public const Cpu.Pin PD2 = (Cpu.Pin)((3 * 16) + 2);

                     

            public const Cpu.Pin BlueLed = Pin.PC6;       // PWM8
            public const Cpu.Pin GreenLed = Pin.PC8;      // PWM10
            public const Cpu.Pin RedLed = Pin.PC9;        // PWM11

            public const Cpu.Pin TempPin = Pin.PB0;       // ACD = 6
            public const Cpu.Pin LightSensor = Pin.PB1;   // ACD = 7 
            public const Cpu.Pin Buzzer = Pin.PB8;        // PWM14


            /// <summary>GPIO NAME</summary>
            public static string GetPinName(Cpu.Pin pin)
            {
                if (pin == Cpu.Pin.GPIO_NONE)
                    return "GPIO_NONE";

                var pinNumber = (int)pin;

                int port = pinNumber / 16;
                int num = pinNumber - 16 * port;
                string result = "P" + (char)('A' + port) + num;
                return result;
            }
        }
        public static class SerialPorts
        {
            public const string COM1 = Serial.COM1;
            public const string COM2 = Serial.COM2;
        }

        public static class BaudRates
        {
            public const BaudRate BaudrateNONE = BaudRate.BaudrateNONE;
            public const BaudRate Baud75 = BaudRate.Baudrate75;
            public const BaudRate Baud150 = BaudRate.Baudrate150;
            public const BaudRate Baud300 = BaudRate.Baudrate300;
            public const BaudRate Baud600 = BaudRate.Baudrate600;
            public const BaudRate Baud1200 = BaudRate.Baudrate1200;
            public const BaudRate Baud2400 = BaudRate.Baudrate2400;
            public const BaudRate Baud4800 = BaudRate.Baudrate4800;
            public const BaudRate Baud9600 = BaudRate.Baudrate9600;
            public const BaudRate Baud19200 = BaudRate.Baudrate19200;
            public const BaudRate Baud38400 = BaudRate.Baudrate38400;
            public const BaudRate Baud57600 = BaudRate.Baudrate57600;
            public const BaudRate Baud115200 = BaudRate.Baudrate115200;
            public const BaudRate Baud230400 = BaudRate.Baudrate230400;
        }

        public static class SpiDevices
        {
            public const SPI.SPI_module SPI1 = SPI.SPI_module.SPI1;
        
        }

        public class ButtonPins
        {
            public const Cpu.Pin Up = Pin.PC13;
            public const Cpu.Pin Down = Pin.PC13;
            public const Cpu.Pin Left = Pin.PC13;
            public const Cpu.Pin Right = Pin.PC13;
        }

        public class Accelerometer
        {
            public const int Address = 10;
        }

        public class OledDisplay
        {
            public const int Address = 60;
            public const int width = 128;
            public const int height = 64;
        }

    }
}
