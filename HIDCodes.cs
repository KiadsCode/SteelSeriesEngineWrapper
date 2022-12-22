using System;
using System.Collections.Generic;

namespace SteelSeries.GameSense
{
	public static class HIDCodes
	{
		public static readonly Dictionary<string, byte> XnaKeyNamesToSteelSeriesKeyIndex = new Dictionary<string, byte>
		{
			{
				"None",
				0
			},
			{
				"Tab",
				43
			},
			{
				"Enter",
				40
			},
			{
				"Pause",
				72
			},
			{
				"CapsLock",
				57
			},
			{
				"Space",
				44
			},
			{
				"PageUp",
				75
			},
			{
				"PageDown",
				78
			},
			{
				"End",
				77
			},
			{
				"Home",
				74
			},
			{
				"Left",
				80
			},
			{
				"Up",
				82
			},
			{
				"Right",
				79
			},
			{
				"Down",
				81
			},
			{
				"Insert",
				73
			},
			{
				"Delete",
				76
			},
			{
				"Help",
				117
			},
			{
				"D0",
				39
			},
			{
				"D1",
				30
			},
			{
				"D2",
				31
			},
			{
				"D3",
				32
			},
			{
				"D4",
				33
			},
			{
				"D5",
				34
			},
			{
				"D6",
				35
			},
			{
				"D7",
				36
			},
			{
				"D8",
				37
			},
			{
				"D9",
				38
			},
			{
				"A",
				4
			},
			{
				"B",
				5
			},
			{
				"C",
				6
			},
			{
				"D",
				7
			},
			{
				"E",
				8
			},
			{
				"F",
				9
			},
			{
				"G",
				10
			},
			{
				"H",
				11
			},
			{
				"I",
				12
			},
			{
				"J",
				13
			},
			{
				"K",
				14
			},
			{
				"L",
				15
			},
			{
				"M",
				16
			},
			{
				"N",
				17
			},
			{
				"O",
				18
			},
			{
				"P",
				19
			},
			{
				"Q",
				20
			},
			{
				"R",
				21
			},
			{
				"S",
				22
			},
			{
				"T",
				23
			},
			{
				"U",
				24
			},
			{
				"V",
				25
			},
			{
				"W",
				26
			},
			{
				"X",
				27
			},
			{
				"Y",
				28
			},
			{
				"Z",
				29
			},
			{
				"NumPad0",
				98
			},
			{
				"NumPad1",
				89
			},
			{
				"NumPad2",
				90
			},
			{
				"NumPad3",
				91
			},
			{
				"NumPad4",
				92
			},
			{
				"NumPad5",
				93
			},
			{
				"NumPad6",
				94
			},
			{
				"NumPad7",
				95
			},
			{
				"NumPad8",
				96
			},
			{
				"NumPad9",
				97
			},
			{
				"F1",
				58
			},
			{
				"F2",
				59
			},
			{
				"F3",
				60
			},
			{
				"F4",
				61
			},
			{
				"F5",
				62
			},
			{
				"F6",
				63
			},
			{
				"F7",
				64
			},
			{
				"F8",
				65
			},
			{
				"F9",
				66
			},
			{
				"F10",
				67
			},
			{
				"F11",
				68
			},
			{
				"F12",
				69
			},
			{
				"F13",
				104
			},
			{
				"F14",
				105
			},
			{
				"F15",
				106
			},
			{
				"F16",
				107
			},
			{
				"F17",
				108
			},
			{
				"F18",
				109
			},
			{
				"F19",
				110
			},
			{
				"F20",
				111
			},
			{
				"F21",
				112
			},
			{
				"F22",
				113
			},
			{
				"F23",
				114
			},
			{
				"F24",
				115
			},
			{
				"NumLock",
				83
			}
		};

		public const byte MOD_LCTRL = 1;

		public const byte MOD_LSHIFT = 2;

		public const byte MOD_LALT = 4;

		public const byte MOD_LMETA = 8;

		public const byte MOD_RCTRL = 16;

		public const byte MOD_RSHIFT = 32;

		public const byte MOD_RALT = 64;

		public const byte MOD_RMETA = 128;

		public const byte NONE = 0;

		public const byte ERR_OVF = 1;

		public const byte A = 4;

		public const byte B = 5;

		public const byte C = 6;

		public const byte D = 7;

		public const byte E = 8;

		public const byte F = 9;

		public const byte G = 10;

		public const byte H = 11;

		public const byte I = 12;

		public const byte J = 13;

		public const byte K = 14;

		public const byte L = 15;

		public const byte M = 16;

		public const byte N = 17;

		public const byte O = 18;

		public const byte P = 19;

		public const byte Q = 20;

		public const byte R = 21;

		public const byte S = 22;

		public const byte T = 23;

		public const byte U = 24;

		public const byte V = 25;

		public const byte W = 26;

		public const byte X = 27;

		public const byte Y = 28;

		public const byte Z = 29;

		public const byte ALPHA_1 = 30;

		public const byte ALPHA_2 = 31;

		public const byte ALPHA_3 = 32;

		public const byte ALPHA_4 = 33;

		public const byte ALPHA_5 = 34;

		public const byte ALPHA_6 = 35;

		public const byte ALPHA_7 = 36;

		public const byte ALPHA_8 = 37;

		public const byte ALPHA_9 = 38;

		public const byte ALPHA_0 = 39;

		public const byte ENTER = 40;

		public const byte ESC = 41;

		public const byte BACKSPACE = 42;

		public const byte TAB = 43;

		public const byte SPACE = 44;

		public const byte MINUS = 45;

		public const byte EQUAL = 46;

		public const byte LEFTBRACE = 47;

		public const byte RIGHTBRACE = 48;

		public const byte BACKSLASH = 49;

		public const byte HASHTILDE = 50;

		public const byte SEMICOLON = 51;

		public const byte APOSTROPHE = 52;

		public const byte GRAVE = 53;

		public const byte COMMA = 54;

		public const byte DOT = 55;

		public const byte SLASH = 56;

		public const byte CAPSLOCK = 57;

		public const byte F1 = 58;

		public const byte F2 = 59;

		public const byte F3 = 60;

		public const byte F4 = 61;

		public const byte F5 = 62;

		public const byte F6 = 63;

		public const byte F7 = 64;

		public const byte F8 = 65;

		public const byte F9 = 66;

		public const byte F10 = 67;

		public const byte F11 = 68;

		public const byte F12 = 69;

		public const byte SYSRQ = 70;

		public const byte SCROLLLOCK = 71;

		public const byte PAUSE = 72;

		public const byte INSERT = 73;

		public const byte HOME = 74;

		public const byte PAGEUP = 75;

		public const byte DELETE = 76;

		public const byte END = 77;

		public const byte PAGEDOWN = 78;

		public const byte RIGHT = 79;

		public const byte LEFT = 80;

		public const byte DOWN = 81;

		public const byte UP = 82;

		public const byte NUMLOCK = 83;

		public const byte KPSLASH = 84;

		public const byte KPASTERISK = 85;

		public const byte KPMINUS = 86;

		public const byte KPPLUS = 87;

		public const byte KPENTER = 88;

		public const byte KP1 = 89;

		public const byte KP2 = 90;

		public const byte KP3 = 91;

		public const byte KP4 = 92;

		public const byte KP5 = 93;

		public const byte KP6 = 94;

		public const byte KP7 = 95;

		public const byte KP8 = 96;

		public const byte KP9 = 97;

		public const byte KP0 = 98;

		public const byte KPDOT = 99;

		public const byte KEY_102ND = 100;

		public const byte COMPOSE = 101;

		public const byte POWER = 102;

		public const byte KPEQUAL = 103;

		public const byte F13 = 104;

		public const byte F14 = 105;

		public const byte F15 = 106;

		public const byte F16 = 107;

		public const byte F17 = 108;

		public const byte F18 = 109;

		public const byte F19 = 110;

		public const byte F20 = 111;

		public const byte F21 = 112;

		public const byte F22 = 113;

		public const byte F23 = 114;

		public const byte F24 = 115;

		public const byte OPEN = 116;

		public const byte HELP = 117;

		public const byte PROPS = 118;

		public const byte FRONT = 119;

		public const byte STOP = 120;

		public const byte AGAIN = 121;

		public const byte UNDO = 122;

		public const byte CUT = 123;

		public const byte COPY = 124;

		public const byte PASTE = 125;

		public const byte FIND = 126;

		public const byte MUTE = 127;

		public const byte VOLUMEUP = 128;

		public const byte VOLUMEDOWN = 129;

		public const byte KPCOMMA = 133;

		public const byte RO = 135;

		public const byte KATAKANAHIRAGANA = 136;

		public const byte YEN = 137;

		public const byte HENKAN = 138;

		public const byte MUHENKAN = 139;

		public const byte KPJPCOMMA = 140;

		public const byte HANGEUL = 144;

		public const byte HANJA = 145;

		public const byte KATAKANA = 146;

		public const byte HIRAGANA = 147;

		public const byte ZENKAKUHANKAKU = 148;

		public const byte KPLEFTPAREN = 182;

		public const byte KPRIGHTPAREN = 183;

		public const byte LEFTCTRL = 224;

		public const byte LEFTSHIFT = 225;

		public const byte LEFTALT = 226;

		public const byte LEFTMETA = 227;

		public const byte RIGHTCTRL = 228;

		public const byte RIGHTSHIFT = 229;

		public const byte RIGHTALT = 230;

		public const byte RIGHTMETA = 231;

		public const byte MEDIA_PLAYPAUSE = 232;

		public const byte MEDIA_STOPCD = 233;

		public const byte MEDIA_PREVIOUSSONG = 234;

		public const byte MEDIA_NEXTSONG = 235;

		public const byte MEDIA_EJECTCD = 236;

		public const byte MEDIA_VOLUMEUP = 237;

		public const byte MEDIA_VOLUMEDOWN = 238;

		public const byte MEDIA_MUTE = 239;

		public const byte MEDIA_WWW = 240;

		public const byte MEDIA_BACK = 241;

		public const byte MEDIA_FORWARD = 242;

		public const byte MEDIA_STOP = 243;

		public const byte MEDIA_FIND = 244;

		public const byte MEDIA_SCROLLUP = 245;

		public const byte MEDIA_SCROLLDOWN = 246;

		public const byte MEDIA_EDIT = 247;

		public const byte MEDIA_SLEEP = 248;

		public const byte MEDIA_COFFEE = 249;

		public const byte MEDIA_REFRESH = 250;

		public const byte MEDIA_CALC = 251;
	}
}
