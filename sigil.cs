/*Sigil Sharp
Written by Andy P.
Copyright (c) 2023
Sigil: 0.9.0
Sigil Wrapper for C#*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace SigilSharp
{
    class sigil
    {
        //Init commands
        [DllImport("Sigil.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void slWindow(int width, int height, string title, int fullScreen);

        [DllImport("Sigil.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void slShowCursor(int show);

        [DllImport("Sigil.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void slClose();

        [DllImport("Sigil.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int slShouldClose();

        //Simple Input commands
        [DllImport("Sigil.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int slGetKey(int key);

        [DllImport("Sigil.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int slGetMouseButton(int btn);

        [DllImport("Sigil.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int slGetMouseX();

        [DllImport("Sigil.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int slGetMouseY();

        //Simple Timing commands
        [DllImport("Sigil.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern double slGetDeltaTime();

        [DllImport("Sigil.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern double slGetTime();

        //Render command
        [DllImport("Sigil.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void slRender();

        //Color control commands
        [DllImport("Sigil.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void slSetBackColor(double red, double green, double blue);

        [DllImport("Sigil.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void slSetForeColor(double red, double green, double blue, double alpha);

        //Blending control commands
        [DllImport("Sigil.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void slSetAdditiveBlend(int additiveBlend);

        //Transformation commands
        [DllImport("Sigil.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void slPush();

        [DllImport("Sigil.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void slPop();

        [DllImport("Sigil.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void slTranslate(double x, double y);

        [DllImport("Sigil.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void slRotate(double degrees);

        [DllImport("Sigil.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void slScale(double x, double y);

        //Texture load command
        [DllImport("Sigil.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int slLoadTexture(string filename);

        //Sound Loading/Playing commands
        [DllImport("Sigil.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int slLoadWAV(string filename);

        [DllImport("Sigil.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int slSoundPlay(int sound);

        [DllImport("Sigil.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int slSoundLoop(int sound);

        [DllImport("Sigil.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void slSoundPause(int sound);

        [DllImport("Sigil.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void slSoundStop(int sound);

        [DllImport("Sigil.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void slSoundPauseAll();

        [DllImport("Sigil.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void slSoundResumeAll();

        [DllImport("Sigil.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void slSoundStopAll();

        [DllImport("Sigil.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int slSoundPlaying(int sound);

        [DllImport("Sigil.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int slSoundLooping(int sound);

        //Simple shape commands
        [DllImport("Sigil.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void slTriangleFill(double x, double y, double width, double height);

        [DllImport("Sigil.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void slTriangleOutline(double x, double y, double width, double height);

        [DllImport("Sigil.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void slRectangleFill(double x, double y, double width, double height);

        [DllImport("Sigil.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void slRectangleOutline(double x, double y, double width, double height);

        [DllImport("Sigil.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void slCircleFill(double x, double y, double radius, int numVertices);

        [DllImport("Sigil.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void slCircleOutline(double x, double y, double radius, int numVertices);

        [DllImport("Sigil.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void slSemiCircleFill(double x, double y, double radius, int numVertices, double degrees);

        [DllImport("Sigil.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void slSemiCircleOutline(double x, double y, double radius, int numVertices, double degress);

        [DllImport("Sigil.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void slPoint(double x, double y);

        [DllImport("Sigil.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void slLine(double x1, double y1, double x2, double y2);

        [DllImport("Sigil.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void slSetSpriteTiling(double x, double y);

        [DllImport("Sigil.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void slSetSpriteScroll(double x, double y);

        [DllImport("Sigil.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void slSprite(int texture, double x, double y, double width, double height);

        //Text commands
        [DllImport("Sigil.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void slSetTextAlign(int fontAlign);

        [DllImport("Sigil.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern double slGetTextWidth(string text);

        [DllImport("Sigil.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern double slGetTextHeight(string text);

        [DllImport("Sigil.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int slLoadFont(string filename);

        [DllImport("Sigil.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void slSetFont(int font, int fontSize);

        [DllImport("Sigil.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void slSetFontSize(int fontSize);

        [DllImport("Sigil.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void slText(double x, double y, string text);

        public sigil()
        {

        }
    }
}
