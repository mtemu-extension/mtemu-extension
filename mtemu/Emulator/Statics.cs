﻿using System;
using System.Collections.Generic;
using System.Text;

namespace mtemu
{
    enum ViewType : byte
    {
        MT_COMMAND,
        MEMORY_POINTER,
        DEVICE_POINTER,
        LOAD_8BIT,
        LOAD_HIGH_4BIT,
        LOAD_LOW_4BIT,
        OFFSET,
        UNKNOWN = 255,
    }

    enum WordType : byte
    {
        AR_HIGH,
        AR_MID,
        AR_LOW,
        CA,
        I68,
        I02,
        I35,
        A,
        B,
        D,
        PT,
        INC,
        PS,
        DEVICE,
        UNKNOWN = 255,
    }

    enum FlagType : byte
    {
        M0,
        M1,
        C0,
        UNKNOWN = 255,
    }

    enum JumpType : byte
    {
        JNZ,
        JMP,
        JNXT,
        END,
        CLNZ,
        CALL,
        RET,
        JSP,
        JSNZ,
        PUSH,
        POP,
        JSNC4,
        JZ,
        JF3,
        JOVR,
        JC4,
        Unknown = 255,
    }

    enum FuncType : byte
    {
        R_PLUS_S = 0,
        S_MINUS_R_MINUS_1 = 1,
        R_MINUS_S_MINUS_1 = 2,
        R_OR_S = 3,
        R_AND_S = 4,
        NO_R_AND_S = 5,
        R_XOR_S = 6,
        R_EQ_S = 7,
        R_PLUS_S_PLUS_1 = 8,
        S_MINUS_R = 9,
        R_MINUS_S = 10,
        SET_POINTER = 11,
        STORE_MEMORY = 12,
        LOAD_MEMORY = 13,
        STORE_DEVICE = 14,
        LOAD_DEVICE = 15,
        UNKNOWN = 255,
    }

    enum FromType : byte
    {
        A_AND_PQ = 0,
        A_AND_B = 1,
        ZERO_AND_Q = 2,
        ZERO_AND_B = 3,
        ZERO_AND_A = 4,
        D_AND_A = 5,
        D_AND_Q = 6,
        D_AND_ZERO = 7,
        UNKNOWN = 255,
    }

    enum ToType : byte
    {
        F_IN_Q = 0,
        NO_LOAD = 1,
        F_IN_B_AND_A_IN_Y = 2,
        F_IN_B = 3,
        SR_F_IN_B_AND_SR_Q_IN_Q = 4,
        SR_F_IN_B = 5,
        SL_F_IN_B_AND_SL_Q_IN_Q = 6,
        SL_F_IN_B = 7,
        UNKNOWN = 255,
    }

    enum ShiftType : byte
    {
        LOGIC = 0,
        CYCLE = 1,
        CYCLE_DOUBLE = 2,
        ARITHMETIC_DOUBLE = 3,
        UNKNOWN = 255,
    }

    enum MemNextPoint : byte
    {
        NO = 0,
        PLUS,
        LOAD,
        UNKNOWN = 255,
    }

    public enum DataPointerType : byte
    {
        LOW_4_BIT = 0,
        HIGH_4_BIT = 1,
        FULL_8_BIT = 2,
        UNKNOWN = 255,
    }

    enum DeviceType : byte
    {
        PORT0 = 0,
        PORT1 = 1,
        PORT2 = 2,
        PORT3 = 3,
        UNKNOWN = 255,
    }
    partial class Call
    {
        public static int ADDRESS_SIZE_BIT = 12;
        public static int ARG_SIZE_BIT = 8;
        public static int NAME_MAX_SIZE = 16;
        public static string STOP_SYMBOL = "\u25CF";

        public static Call GetDefault()
        {
            return new Call(0, 0, 0, false);
        }

        public static int CallSize()
        {
            return 3 * sizeof(UInt16) + sizeof(byte) + 2 * sizeof(bool);
        }
    }

    partial class Command
    {
        public static int WORD_SIZE = 4;
        private static int length_ = 10;

        // Numbers of text boxes
        private static Dictionary<WordType, int> wordIndexes_ =
            new Dictionary<WordType, int>
        {
            { WordType.AR_HIGH, 0 },
            { WordType.AR_MID, 1 },
            { WordType.AR_LOW, 2 },
            { WordType.CA, 3 },
            { WordType.I68, 4 },
            { WordType.I02, 5 },
            { WordType.I35, 6 },
            { WordType.A, 7 },
            { WordType.B, 8 },
            { WordType.D, 9 },
            { WordType.PT, 5 },
            { WordType.INC, 5 },
            { WordType.PS, 5 },
            { WordType.DEVICE, 7 },
        };

        private static Dictionary<ViewType, string[]> labels_ =
            new Dictionary<ViewType, string[]>
        {
            {
                ViewType.MT_COMMAND, new string[] {
                    "AR",
                    "CA",
                    "M1|I6-I8",
                    "M0|I0-I2",
                    "C0|I3-I5",
                    "A",
                    "B",
                    "D",
                }
            },
            {
                ViewType.MEMORY_POINTER, new string[] {
                    "AR",
                    "CA",
                    "",
                    "PT|Inc",
                    "F",
                    "PtrHigh",
                    "PtrLow",
                    "",
                }
            },
            {
                ViewType.DEVICE_POINTER, new string[] {
                    "AR",
                    "CA",
                    "",
                    "PT",
                    "F",
                    "Port",
                    "",
                    "",
                }
            },
            {
                ViewType.LOAD_8BIT, new string[] {
                    "AR",
                    "CA",
                    "",
                    "PT",
                    "F",
                    "A",
                    "B",
                    "D",
                }
            },
            {
                ViewType.LOAD_HIGH_4BIT, new string[] {
                    "AR",
                    "CA",
                    "",
                    "PT",
                    "F",
                    "A",
                    "",
                    "D",
                }
            },
            {
                ViewType.LOAD_LOW_4BIT, new string[] {
                    "AR",
                    "CA",
                    "",
                    "PT",
                    "F",
                    "",
                    "B",
                    "D",
                }
            },
            {
                ViewType.OFFSET, new string[] {
                    "Offset",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                }
            },
        };

        private static Dictionary<WordType, string[][]> items_ =
            new Dictionary<WordType, string[][]>
        {
            {
                WordType.CA, new string[][] {
                    new string[] {"","0000","JNZ"},
                    new string[] {"","0001","JMP"},
                    new string[] {"","0010","JNXT"},
                    new string[] {"","0011","END/LDM"},
                    new string[] {"","0100","CLNZ"},
                    new string[] {"","0101","CALL"},
                    new string[] {"","0110","RET"},
                    new string[] {"","0111","JSP"},
                    new string[] {"","1000","JSNZ"},
                    new string[] {"","1001","PUSH"},
                    new string[] {"","1010","POP"},
                    new string[] {"","1011","JSNC4"},
                    new string[] {"","1100","JZ"},
                    new string[] {"","1101","JF3"},
                    new string[] {"","1110","JOVR"},
                    new string[] {"","1111","JC4"},
                }
            },
            {
                WordType.I68, new string[][] {
                    new string[] {"","000","PQ=F"},
                    new string[] {"","001","Нет загрузки"},
                    new string[] {"","010","Y=РОН(A), РОН(B)=F"},
                    new string[] {"","011","РОН(B)=F"},
                    new string[] {"","100","PQ=Q/2, РОН(B)=F/2"},
                    new string[] {"","101","РОН(B)=F/2"},
                    new string[] {"","110","PQ=2Q, РОН(B)=2F"},
                    new string[] {"","111","РОН(B)=2F"},
                }
            },
            {
                WordType.I02, new string[][] {
                    new string[] {"","000","РОН(A)","PQ"},
                    new string[] {"","001","РОН(A)","РОН(B)"},
                    new string[] {"","010","0","PQ"},
                    new string[] {"","011","0","РОН(B)"},
                    new string[] {"","100","0","РОН(A)"},
                    new string[] {"","101","D","РОН(A)"},
                    new string[] {"","110","D","PQ"},
                    new string[] {"","111","D","0"},
                }
            },
            {
                WordType.I35, new string[][] {
                    new string[] {"","0000","R+S+C0","0"},
                    new string[] {"","0001","S-R-1+C0","0"},
                    new string[] {"","0010","R-S-1+C0","0"},
                    new string[] {"","0011","R∨S","-"},
                    new string[] {"","0100","R∧S","-"},
                    new string[] {"","0101","¬R∧S","-"},
                    new string[] {"","0110","R⊕S","-"},
                    new string[] {"","0111","¬(R⊕S)","-"},
                    new string[] {"","1000","R+S+C0","1"},
                    new string[] {"","1001","S-R-1+C0","1"},
                    new string[] {"","1010","R-S-1+C0","1"},
                    new string[] {"","1011","Set Ptr","-"},
                    new string[] {"","1100","Str Mem","-"},
                    new string[] {"","1101","Load Mem","-"},
                    new string[] {"","1110","Str Dev","-"},
                    new string[] {"","1111","Load Dev","-"},
                }
            },
            {
                WordType.PT, new string[][] {
                    new string[] {"","0000","Память; P=P"},
                    new string[] {"","0001","Память; P=P+1"},
                    new string[] {"","0010","Память; P=РОН"},
                    new string[] {"","1000","Регистр устр."},
                }
            },
            {
                WordType.PS, new string[][] {
                    new string[] {"","0000","Младш. 4 бита"},
                    new string[] {"","0001","Старш. 4 бита"},
                    new string[] {"","0010","8 бит"},
                }
            },
            {
                WordType.DEVICE, new string[][] {
                    new string[] {"","0000","GPIOA/UART"},
                    new string[] {"","0001","GPIOC/SPI"},
                    new string[] {"","0010","GPIOE/I2C"},
                    new string[] {"","0011","Ctrl Reg"},
                }
            },
        };

        public static int GetTextIndexByType(WordType type)
        {
            if (wordIndexes_.ContainsKey(type))
            {
                return wordIndexes_[type];
            }
            return -1;
        }

        public static int GetTextIndexByFlag(FlagType type)
        {
            switch (type)
            {
                case FlagType.M0:
                    return wordIndexes_[WordType.I02];
                case FlagType.M1:
                    return wordIndexes_[WordType.I68];
                case FlagType.C0:
                    return wordIndexes_[WordType.I35];
            }
            return -1;
        }

        public static string[][] GetItems(WordType listIndex)
        {
            return items_[listIndex];
        }

        public static string GetPortName(int number)
        {
            var items = items_[WordType.DEVICE];
            if (number < 0 || number >= items.Length)
            {
                return "NONE";
            }

            return $"{items[number][2]}";
        }

        public static Command GetDefault()
        {
            return new Command(new string[] {
                "0000", "0000", "0000", "0010", "0001", "0111", "0000", "0000", "0000", "0000",
            });
        }

        public static Command GetIncorrect()
        {
            return new Command(new int[] { 0xF, 0xF, 0xF, 0xF, 0xF, 0xF, 0xF, 0xF, 0xF, 0xF });
        }
    }

    partial class Emulator
    {
        private static Command incorrectCommand_ = Command.GetIncorrect();

        private static int commandSize_ = 5;
        private static byte[] fileHeader_ = Encoding.ASCII.GetBytes("MTEM");
        private static byte[] binFileHeader_ = Encoding.ASCII.GetBytes("");

        private static int programSize_ = 1 << 12;
        private static int userProgramSize = 0xf00;
        private static int stackSize_ = 1 << 4;
        private static int regSize_ = 1 << 4;
        private static int memSize_ = 1 << 8;
        private static int maxAutoCount_ = 1 << 14;

        public enum JumpResult
        {
            Next,
            Address,
        };

        public enum ResultCode
        {
            Ok,
            NoCommands,
            IncorrectCommand,
            Loop,
            End,
        };

        public static int GetStackSize()
        {
            return stackSize_;
        }

        public static int GetRegSize()
        {
            return regSize_;
        }

        public static int GetMemorySize()
        {
            return memSize_;
        }

        // code => {name, address}
        public static Dictionary<int, Tuple<string, int>> mapJumps_ => new Dictionary<int, Tuple<string, int>>
        {
            {0, new Tuple<string, int>("JMP", 0xffb) },
            {1, new Tuple<string, int>("JC", 0xffc) },
            {2, new Tuple<string, int>("JZ", 0xffd) },
            {3, new Tuple<string, int>("JNC", 0xffe) },
            {4, new Tuple<string, int>("JNZ", 0xfff) },
            {5, new Tuple<string, int>("UART LOAD", 0xf16) },
            {6, new Tuple<string, int>("SPI LOAD", 0xf1d) },
            {7, new Tuple<string, int>("I2C LOAD", 0xf24) },
            {8, new Tuple<string, int>("UART READ", 0xf2b) },
            {9, new Tuple<string, int>("SPI READ", 0xf30) },
            {10, new Tuple<string, int>("I2C READ", 0xf35) },
        };

        public static List<Command> callCommands => new List<Command>
        {
            // UART LOAD
            new Command(
                new string[] {"1111", "0001", "0110", "0000", "0000", "0000", "0000", "0000", "0000", "0000"},
                true
                ),
            new Command(
                new string[] {"0000", "0000", "0000", "0010", "0001", "1000", "1011", "0011", "0000", "0000"}
                ),
              new Command(
                new string[] {"0000", "0000", "0000", "0010", "0011", "1111", "0000", "0000", "0000", "1000"}
                ),
            new Command(
                new string[] {"0000", "0000", "0000", "0010", "0001", "0010", "1110", "0000", "0001", "0000"}
                ),
            new Command(
                new string[] {"0000", "0000", "0000", "0010", "0001", "0000", "1011", "0000", "0000", "0000"}
                ),
            new Command(
                new string[] {"0000", "0000", "0000", "0010", "0001", "0010", "1101", "0000", "0001", "0000"}
                ),
            new Command(
                new string[] {"0000", "0000", "0000", "0010", "0001", "1000", "1011", "0000", "0001", "0000"}
                ),
            new Command(
                new string[] {"0000", "0000", "0000", "0011", "0001", "0010", "1110", "0000", "0001", "0000"}
                ),
            // SPI LOAD
            new Command(
                new string[] {"1111", "0001", "1101", "0000", "0000", "0000", "0000", "0000", "0000", "0000"},
                true
                ),
            new Command(
                new string[] {"0000", "0000", "0000", "0010", "0001", "1000", "1011", "0011", "0000", "0000"}
                ),
             new Command(
                new string[] {"0000", "0000", "0000", "0010", "0011", "1111", "0000", "0000", "0000", "0100"}
                ),
            new Command(
                new string[] {"0000", "0000", "0000", "0010", "0001", "0010", "1110", "0000", "0001", "0000"}
                ),
             new Command(
                new string[] {"0000", "0000", "0000", "0010", "0001", "0000", "1011", "0000", "0000", "0000"}
                ),
            new Command(
                new string[] {"0000", "0000", "0000", "0010", "0001", "0010", "1101", "0000", "0001", "0000"}
                ),
            new Command(
                new string[] {"0000", "0000", "0000", "0010", "0001", "1000", "1011", "0001", "0001", "0000"}
                ),
            new Command(
                new string[] {"0000", "0000", "0000", "0011", "0001", "0010", "1110", "0000", "0001", "0010"}
                ),
            // I2C LOAD
            new Command(
                new string[] {"1111", "0010", "0100", "0000", "0000", "0000", "0000", "0000", "0000", "0000"},
                true
                ),
            new Command(
                new string[] {"0000", "0000", "0000", "0010", "0001", "1000", "1011", "0011", "0000", "0000"}
                ),
           new Command(
                new string[] {"0000", "0000", "0000", "0010", "0011", "1111", "0000", "0000", "0000", "0010"}
                ),
            new Command(
                new string[] {"0000", "0000", "0000", "0010", "0001", "0010", "1110", "0000", "0001", "0000"}
                ),
             new Command(
                new string[] {"0000", "0000", "0000", "0010", "0001", "0000", "1011", "0000", "0000", "0000"}
                ),
            new Command(
                new string[] {"0000", "0000", "0000", "0010", "0001", "0010", "1101", "0000", "0001", "0000"}
                ),
            new Command(
                new string[] {"0000", "0000", "0000", "0010", "0001", "1000", "1011", "0010", "0001", "0000"}
                ),
            new Command(
                new string[] {"0000", "0000", "0000", "0011", "0001", "0010", "1110", "0000", "0001", "0000"}
                ),
            // UART READ
            new Command(
                new string[] {"1111", "0010", "1011", "0000", "0000", "0000", "0000", "0000", "0000", "0000"},
                true
                ),
            new Command(
                new string[] {"0000", "0000", "0000", "0010", "0001", "1000", "1011", "0011", "0000", "0000"}
                ),
            new Command(
                new string[] {"0000", "0000", "0000", "0010", "0011", "1111", "0000", "0000", "0000", "1000"}
                ),
            new Command(
                new string[] {"0000", "0000", "0000", "0010", "0001", "0010", "1110", "0000", "0001", "0000"}
                ),
            new Command(
                new string[] {"0000", "0000", "0000", "0010", "0001", "1000", "1011", "0000", "0001", "0000"}
                ),
            new Command(
                new string[] {"0000", "0000", "0000", "0011", "0001", "0010", "1111", "0000", "0001", "0000"}
                ),
            // SPI READ
            new Command(
                new string[] {"1111", "0011", "0000", "0000", "0000", "0000", "0000", "0000", "0000", "0000"},
                true
                ),
            new Command(
                new string[] {"0000", "0000", "0000", "0010", "0001", "1000", "1011", "0011", "0000", "0000"}
                ),
             new Command(
                new string[] {"0000", "0000", "0000", "0010", "0011", "1111", "0000", "0000", "0000", "0100"}
                ),
            new Command(
                new string[] {"0000", "0000", "0000", "0010", "0001", "0010", "1110", "0000", "0001", "0000"}
                ),
            new Command(
                new string[] {"0000", "0000", "0000", "0010", "0001", "1000", "1011", "0001", "0001", "0000"}
                ),
            new Command(
                new string[] {"0000", "0000", "0000", "0011", "0001", "0010", "1111", "0000", "0001", "0010"}
                ),
            // I2C READ
            new Command(
                new string[] {"1111", "0011", "0101", "0000", "0000", "0000", "0000", "0000", "0000", "0000"},
                true
                ),
            new Command(
                new string[] {"0000", "0000", "0000", "0010", "0001", "1000", "1011", "0011", "0000", "0000"}
                ),
             new Command(
                new string[] {"0000", "0000", "0000", "0010", "0011", "1111", "0000", "0000", "0000", "0010"}
                ),
            new Command(
                new string[] {"0000", "0000", "0000", "0010", "0001", "0010", "1110", "0000", "0001", "0000"}
                ),
            new Command(
                new string[] {"0000", "0000", "0000", "0010", "0001", "1000", "1011", "0010", "0001", "0000"}
                ),
            new Command(
                new string[] {"0000", "0000", "0000", "0011", "0001", "0010", "1111", "0000", "0001", "0000"}
                ),
            // JUMPS
            new Command(
                new string[] {"1111", "1111", "1011", "0000", "0000", "0000", "0000", "0000", "0000", "0000"},
                true
                ),
            new Command(
                new string[] {"0000", "0000", "0000", "0011", "0001", "0111", "0000", "0000", "0000", "0000"}
                ),
            new Command(
                new string[] {"0000", "0000", "0000", "0011", "0001", "0111", "0000", "0000", "0000", "0000"}
                ),
            new Command(
                new string[] {"0000", "0000", "0000", "0011", "0001", "0111", "0000", "0000", "0000", "0000"}
                ),
            new Command(
                new string[] {"0000", "0000", "0000", "0011", "0001", "0111", "0000", "0000", "0000", "0000"}
                ),
            new Command(
                new string[] {"0000", "0000", "0000", "0011", "0001", "0111", "0000", "0000", "0000", "0000"}
                ),
        };
    }
}
