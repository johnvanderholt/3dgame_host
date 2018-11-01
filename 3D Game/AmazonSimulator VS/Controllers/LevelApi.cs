﻿using System;
using System.Collections.Generic;
using Levels;
using Microsoft.AspNetCore.Mvc;

namespace Controllers
{
    [Route("api/[controller]")]
    public class LevelsController: Controller
    {
        // GET api/levels/[level nummer]
        [HttpGet("{id}")]
        public string Get(int id)
        {
            switch (id)
            {
                case 1:
                    Levels.Level level_1 = new Level(AllLevels.level_1);
                    return level_1.get_json();
                case 2:
                    Levels.Level level_2 = new Level(AllLevels.level_2);
                    return level_2.get_json();
                case 3:
                    Levels.Level level_3 = new Level(AllLevels.level_3);
                    return level_3.get_json();
                case 4:
                    Levels.Level level_4 = new Level(AllLevels.level_4);
                    return level_4.get_json();
                case 5:
                    Levels.Level level_5 = new Level(AllLevels.level_5);
                    return level_5.get_json();
                case 6:
                    Levels.Level level_6 = new Level(AllLevels.level_6);
                    return level_6.get_json();
                case 7:
                    Levels.Level level_7 = new Level(AllLevels.level_7);
                    return level_7.get_json();
                case 8:
                    Levels.Level level_8 = new Level(AllLevels.level_8);
                    return level_8.get_json();
                case 9:
                    Levels.Level level_9 = new Level(AllLevels.level_9);
                    return level_9.get_json();
                case 10:
                    Levels.Level level_10 = new Level(AllLevels.level_10);
                    return level_10.get_json();
                case 11:
                    Levels.Level level_11 = new Level(AllLevels.level_11);
                    return level_11.get_json();
                case 12:
                    Levels.Level test_level = new Level(AllLevels.test_level);
                    return test_level.get_json();
            }
            return null;
        }
    }
}