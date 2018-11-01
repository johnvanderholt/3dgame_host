﻿using System;
using System.Collections.Generic;
using Controllers;

namespace Levels
{
    public class AllLevels
    {
        public char[,] test_level =
        {
            {'l','l','l','l','l'},
            {'l','s','v','e','l'},
            {'l','l','l','l','l'}
        };

        public static char[,] level_1 =
        {
                {'v','v','v','l','l','l','l','l','l','l'},
                {'v','b','v','v','v','v','l','l','l','l'},
                {'v','v','v','v','v','v','v','v','v','l'},
                {'l','v','v','v','v','v','v','v','v','v'},
                {'l','l','l','l','l','v','v','e','v','v'},
                {'l','l','l','l','l','l','v','v','v','l'}
        };

        public static char[,] level_2 =
        {
                {'l','l','l','l','l','l','v','v','v','v','v','v','v','l','l'},
                {'v','v','v','v','l','l','v','v','v','l','l','v','v','l','l'},
                {'v','v','b','v','v','v','v','v','v','l','l','v','v','v','v'},
                {'v','v','v','v','l','l','l','l','l','l','l','v','v','e','v'},
                {'v','v','v','v','l','l','l','l','l','l','l','l','v','v','v'}
        };

        public static char[,] level_3 =
        {
                {'l','l','l','l','l','v','v','v','v','v','v','l','l','l','l'},
                {'l','l','l','l','l','v','l','l','v','v','v','l','l','l','l'},
                {'l','l','l','l','l','v','l','l','v','v','v','v','v','l','l'},
                {'v','b','v','v','v','v','l','l','l','l','l','v','v','v','v'},
                {'l','l','l','l','v','v','v','l','l','l','l','v','v','e','v'},
                {'l','l','l','l','v','v','v','l','l','l','l','l','v','v','v'},
                {'l','l','l','l','l','l','v','l','l','v','v','l','l','l','l'},
                {'l','l','l','l','l','l','v','v','v','v','v','l','l','l','l'},
                {'l','l','l','l','l','l','v','v','v','v','v','l','l','l','l'},
                {'l','l','l','l','l','l','l','v','v','v','l','l','l','l','l'}
        };

        public static char[,] level_4 =
        {
                {'l','l','v','v','l','l','v','v','l','l','l'},
                {'l','v','v','v','v','v','v','v','l','l','v'},
                {'l','v','e','v','l','l','l','v','v','v','v'},
                {'l','v','v','v','l','l','l','l','v','v','v'},
                {'l','l','l','l','l','l','l','l','l','v','v'},
                {'l','l','l','l','v','v','v','l','l','v','v'},
                {'v','v','v','v','v','v','v','l','l','v','v'},
                {'v','v','b','v','v','v','v','v','v','v','v'}
        };

        public static char[,] level_5 =
        {
                {'v','v','v','v','v','v','v','v','v','v','v','v','v','l'},
                {'v','v','l','l','l','l','l','l','l','l','v','v','v','l'},
                {'v','v','l','l','l','l','l','l','l','l','l','v','v','v'},
                {'v','v','v','l','l','l','v','v','v','l','l','v','b','v'},
                {'v','v','v','v','v','v','v','e','v','l','l','v','v','v'},
                {'v','v','v','l','l','v','v','v','v','l','l','v','l','l'},
                {'l','l','v','l','l','v','v','v','v','v','v','v','l','l'},
                {'l','l','v','v','v','v','v','v','v','v','v','v','l','l'},
                {'l','l','l','v','v','v','v','v','v','v','v','l','l','l'},
                {'l','l','l','v','v','v','l','l','v','v','l','l','l','l'}
        };

        public static char[,] level_6 =
        {
                {'v','v','v','v','v','v','l'},
                {'v','l','v','v','l','v','l'},
                {'v','l','v','v','v','v','v'},
                {'b','l','l','l','v','e','v'},
                {'l','l','l','l','v','v','v'}
        };

        public static char[,] level_7 =
        {
            { 'l', 'l', 'l', 'l', 'l', 'e', 'l', 'l', 'l', 'l', 'l', 'l' },
            { 'l', 'l', 'l', 'l', 'l', 'v', 'l', 'l', 'l', 'l', 'l', 'l' },
            { 'l', 'l', 'v', 'v', 'v', 'v', 'l', 'l', 'l', 'l', 'l', 'l' },
            { 'l', 'l', 'b', 'l', 'l', 'v', 'v', 'v', 'v', 'v', 'v', 'v' },
            { 'l', 'l', 'v', 'l', 'l', 'v', 'l', 'l', 'l', 'l', 'v', 'v' },
            { 'v', 'v', 'v', 'l', 'l', 'v', 'v', 'v', 'l', 'v', 'v', 'v' },
            { 'v', 'v', 'v', 'l', 'l', 'l', 'v', 'v', 'v', 'v', 'v', 'l' },
            { 'l', 'l', 'l', 'l', 'l', 'l', 'l', 'l', 'l', 'l', 'v', 'l' },
            { 'l', 'l', 'l', 'l', 'l', 'l', 'l', 'l', 'v', 'v', 'v', 'l' },
            { 'l', 'l', 'l', 'l', 'l', 'l', 'l', 'l', 'v', 'v', 'v', 'l' }
        };

        public static char[,] level_8 = 
        {
            {'l','l','l','l','l','l','l','l','l','l','l','l','v','v','v','v','v','l','l','l','l','l','l','l','l','l','l','l','l','l','l'},
            {'l','l','l','l','l','l','l','l','l','l','v','v','v','v','v','v','v','l','l','v','v','v','v','v','l','l','l','l','l','l','l'},
            {'l','v','v','v','v','v','v','v','l','l','v','v','v','v','v','v','l','l','l','v','l','l','v','v','l','l','l','l','l','l','l'},
            {'v','v','v','v','l','l','v','v','l','l','v','v','l','l','l','v','l','l','l','v','l','l','v','v','l','l','l','l','v','v','v'},
            {'v','v','b','v','l','l','v','v','v','v','v','v','l','l','l','v','v','v','v','v','v','v','v','v','v','v','v','v','v','e','v'},
            {'v','v','v','v','l','l','v','v','l','l','v','v','l','l','l','v','l','l','l','v','l','l','v','v','l','l','l','l','v','v','v'},
            {'l','v','v','v','v','v','v','v','l','l','v','v','v','v','v','v','l','l','l','v','l','l','v','v','l','l','l','l','l','l','l'},
            {'l','l','l','l','l','l','l','l','l','l','v','v','v','v','v','v','v','l','l','v','v','v','v','v','l','l','l','l','l','l','l'},
            {'l','l','l','l','l','l','l','l','l','l','l','l','v','v','v','v','v','l','l','l','l','l','l','l','l','l','l','l','l','l','l'}
        };

        public static char[,] level_9 =
        {
            {'l','l','l','l','l','l','l','l','l','v','v','v','v','v','v','v','v','l','l','l','l','l','l','l'},
            {'l','l','l','l','l','l','l','l','l','v','v','v','l','l','v','v','v','l','l','l','l','l','l','l'},
            {'l','l','l','l','l','l','l','l','l','v','v','v','l','l','v','v','v','l','l','l','l','l','l','l'},
            {'l','l','l','l','l','l','l','l','l','l','v','v','l','l','l','v','l','l','l','l','l','l','l','l'},
            {'l','l','v','v','v','v','v','v','l','l','l','v','v','l','l','v','l','l','l','l','l','l','l','l'},
            {'l','l','v','l','l','l','v','v','v','l','l','v','v','l','l','v','v','v','v','l','l','l','l','l'},
            {'l','l','v','l','l','l','v','v','v','l','l','v','v','l','l','v','v','v','v','l','l','l','l','l'},
            {'l','l','v','l','l','l','l','l','v','l','l','v','v','l','l','l','l','l','v','l','l','v','v','l'},
            {'v','v','v','v','v','l','l','l','v','v','l','l','v','l','l','l','l','l','v','v','v','v','v','v'},
            {'v','v','s','v','v','l','l','l','v','v','l','l','v','l','l','l','l','l','l','v','v','v','e','v'},
            {'v','v','v','v','v','l','l','l','v','v','l','l','v','l','l','l','l','l','l','l','l','v','v','v'},
            {'l','l','l','l','l','l','l','l','l','v','v','v','v','l','l','l','l','l','l','l','l','v','v','l'}
        };

        public static char[,] level_10 =
        {
            {'l','l','l','v','v','v','v','v','v','v','v','v','l'},
            {'l','l','l','v','l','l','l','l','v','v','v','v','l'},
            {'l','v','v','v','l','l','l','l','v','v','l','l','l'},
            {'l','v','v','v','v','v','l','l','v','v','l','l','l'},
            {'l','v','v','v','v','v','l','l','l','v','v','v','l'},
            {'l','l','l','l','l','v','l','l','l','l','v','v','l'},
            {'l','l','l','l','l','v','l','l','l','l','v','v','l'},
            {'l','l','l','v','v','v','l','l','l','v','v','v','l'},
            {'l','l','l','v','v','l','l','l','l','v','l','l','l'},
            {'l','l','l','v','v','l','l','l','l','v','l','l','l'},
            {'l','l','v','v','v','l','l','l','l','v','v','v','l'},
            {'l','l','v','l','l','l','l','l','l','l','v','v','v'},
            {'l','l','v','l','l','l','l','v','v','l','l','l','v'},
            {'v','v','v','v','v','l','l','v','v','v','l','l','v'},
            {'v','v','b','v','v','l','l','v','e','v','v','v','v'},
            {'v','v','v','v','v','l','l','v','v','v','l','l','l'}
        };

        public static char [,] level_11 =
        {
            {'l','l','l','v','l','l','l','l','l','l','l','l','l','l','l','l','l','l','l','l','l','l','l','l','l','l','l','l'},
            {'l','l','v','v','v','l','l','l','l','l','l','l','l','l','l','l','l','l','l','l','l','l','l','l','l','l','l','l'},
            {'l','v','v','v','v','v','l','l','l','l','l','l','l','l','l','l','l','l','l','l','l','l','l','l','l','l','l','l'},
            {'v','v','v','b','v','v','v','l','l','l','l','l','l','l','l','l','v','v','v','b','l','l','l','l','l','l','l','l'},
            {'l','v','v','v','v','v','l','l','l','l','l','l','l','l','l','l','v','l','l','v','l','l','l','l','l','l','l','l'},
            {'l','l','v','v','v','v','l','l','l','l','v','v','v','l','l','l','v','l','l','v','l','l','l','l','l','l','l','l'},
            {'l','l','l','l','l','v','l','l','l','l','v','v','v','l','l','l','v','l','l','v','l','l','l','l','l','l','l','l'},
            {'l','l','l','l','l','v','v','v','v','v','v','v','v','l','l','l','v','l','l','v','l','l','l','l','l','l','l','l'},
            {'v','v','v','v','l','l','l','v','l','l','l','l','l','l','l','l','v','l','l','v','l','l','l','l','l','l','l','l'},
            {'v','v','v','v','l','l','l','v','l','l','l','l','l','l','l','l','v','l','l','v','l','l','l','l','l','l','l','l'},
            {'v','v','v','v','l','l','v','v','v','v','v','v','l','l','l','l','v','l','l','v','v','l','l','l','v','v','v','l'},
            {'v','v','v','v','v','v','v','v','l','l','v','v','l','l','l','l','v','l','l','v','v','v','l','l','v','v','v','l'},
            {'l','l','l','l','l','l','l','v','l','l','v','v','l','l','l','l','v','l','l','l','v','v','v','v','v','v','v','l'},
            {'l','l','l','l','l','l','l','v','l','l','l','l','l','l','l','l','v','l','l','l','l','v','l','v','v','l','l','l'},
            {'l','l','l','l','l','l','l','v','l','l','l','l','l','l','l','l','v','v','v','v','l','l','l','v','v','l','l','l'},
            {'l','l','l','l','l','l','l','v','l','l','l','l','l','l','l','l','v','l','l','v','l','l','v','v','v','v','l','l'},
            {'l','l','l','l','l','l','l','v','l','l','l','l','l','l','l','l','v','l','l','v','l','l','v','v','e','v','l','l'},
            {'l','l','l','l','l','l','l','v','v','v','v','v','v','v','v','v','v','l','l','v','l','l','l','v','v','l','l','l'},
            {'l','l','l','l','l','l','l','l','l','l','l','l','l','l','l','l','v','l','l','v','v','v','l','l','l','l','l','l'},
            {'l','l','l','l','l','l','l','l','l','l','l','l','l','l','l','l','v','v','v','v','v','v','l','l','l','l','l','l'},
            {'l','l','l','l','l','l','l','l','l','l','l','l','l','l','l','l','v','v','v','v','v','v','l','l','l','l','l','l'},
            {'l','l','l','l','l','l','l','l','l','l','l','l','l','l','l','l','v','v','v','v','v','v','l','l','l','l','l','l'},
        };






}
}