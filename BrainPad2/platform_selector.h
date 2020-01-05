#ifndef _PLATFORM_BrainPad2_SELECTOR_H_
#define _PLATFORM_BrainPad2_SELECTOR_H_
/////////////////////////////////////////////////////////
//
// processor and features
//
#if defined(PLATFORM_ARM_BrainPad2)
#define HAL_SYSTEM_NAME "BrainPad2"
#define PLATFORM_ARM_STM32F4  // STM32F4XX
#define STM32F40_41xxx
#define USB_ALLOW_CONFIGURATION_OVERRIDE 1
//
// processor and features
//
/////////////////////////////////////////////////////////
/////////////////////////////////////////////////////////
//
// constants
//
// System clock
#define SYSTEM_CLOCK_HZ                  96000000   //  96 MHz
#define SYSTEM_CYCLE_CLOCK_HZ            96000000   //  96 MHz
#define SYSTEM_APB1_CLOCK_HZ             48000000   //  48 MHz
#define SYSTEM_APB2_CLOCK_HZ             96000000   //  96 MHz
#define SYSTEM_CRYSTAL_CLOCK_HZ           8000000   // 8 MHz external clock
#define CLOCK_COMMON_FACTOR               1000000   // GCD(SYSTEM_CLOCK_HZ, 1M)
#define SLOW_CLOCKS_PER_SECOND            1000000   // 1 MHz
#define SLOW_CLOCKS_TEN_MHZ_GCD           1000000   // GCD(SLOW_CLOCKS_PER_SECOND, 10M)
#define SLOW_CLOCKS_MILLISECOND_GCD          1000   // GCD(SLOW_CLOCKS_PER_SECOND, 1k)

#define SUPPLY_VOLTAGE_MV                    3300   // 3.3V supply
// Memory
#define FLASH_MEMORY_Base               0x08000000
#define FLASH_MEMORY_Size               0x00080000  // 512K
#define SRAM1_MEMORY_Base               0x20000000
#define SRAM1_MEMORY_Size               0x00018000  // 96K

//#define PLATFORM_DEPENDENT_TX_USART_BUFFER_SIZE   1024
//#define PLATFORM_DEPENDENT_RX_USART_BUFFER_SIZE   1024

// GPIO
#define GPIO_PORTA 0
#define GPIO_PORTB 1
#define GPIO_PORTC 2
#define GPIO_PORTD 3
// The remaining ports are not broken out - except PD2, PH0 and PH1,
// which are deliberately omitted to reduce memory consumption (PD2)
// and to keep the range continuous (PH0, PH1).
#define TOTAL_GPIO_PORT                 (GPIO_PORTD + 1)
#define TOTAL_GPIO_PINS                 (TOTAL_GPIO_PORT*16)
#define PORT_PIN(port,pin)              (((int)port)*16 + (pin))

// Communication
#define TOTAL_USART_PORT                2 
#define USART_DEFAULT_PORT              COM1
#define USART_DEFAULT_BAUDRATE          115200

#define TOTAL_GENERIC_PORTS             1 // 1 generic port extensions (ITM channel 0 )
#define ITM_GENERIC_PORTNUM             0 // ITM0 is index 0 in generic port interface table

#define DEBUG_TEXT_PORT                 ITM0
#define STDIO                           ITM0

#define DEBUGGER_PORT                   USB1
#define MESSAGING_PORT                  USB1

#define TOTAL_USB_CONTROLLER            1
#define USB_MAX_QUEUES                  4  // 4 endpoints (EP0 + 3)

#define STM32F4_32B_TIMER 5 // |   2   |   5    |
#define STM32F4_16B_TIMER 3 // |3,4,8,9|1,3,8,12|

// Pin Configuration
#define STM32F4_ADC 1
#define STM32F4_AD_CHANNELS {0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15} // PA0-PA4,PB0-PB1,PC0-PC3

#define STM32F4_PWM_TIMER {1,1,1,1,2,2,2,3,3,3,3,4,4,4,4}
#define STM32F4_PWM_CHNL  {0,1,2,3,1,2,2,0,1,2,3,0,1,2,3}
#define STM32F4_PWM_PINS  {8,9,10,0,1,2,3,38,39,40,41,22,23,24,25} //PA8 PA9 PA10 PA0 PA1 PA2 PA3 PC6 PC7 PC8 PC9 PB6 PB7 PB8 PB9

#define STM32F4_SPI_SCLK_PINS {19} // PB3
#define STM32F4_SPI_MISO_PINS {20} // PB4
#define STM32F4_SPI_MOSI_PINS {21} // PB5

#define STM32F4_I2C_PORT     1
#define STM32F4_I2C_SCL_PIN  22 // PB6
#define STM32F4_I2C_SDA_PIN  23 // PB7

#define STM32F4_UART_RXD_PINS {10,  3} // PA10, PA3
#define STM32F4_UART_TXD_PINS { 9,  2} // PA9,  PA2
#define STM32F4_UART_CTS_PINS {GPIO_PIN_NONE, GPIO_PIN_NONE} // NA, PA0
#define STM32F4_UART_RTS_PINS {GPIO_PIN_NONE, GPIO_PIN_NONE} // NA, PA1
//
// constants
/////////////////////////////////////////////////////////
#include <processor_selector.h>
#endif // PLATFORM_ARM_BrainPad2
#endif // _PLATFORM_BrainPad2_SELECTOR_H_
