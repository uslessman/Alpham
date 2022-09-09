﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharpDX;

namespace Alpha
{
    public class TaskNode
    {
        /// <summary>
        /// The position of the task in world space.
        /// </summary>
        public Vector3 WorldPosition { get; set; }
        /// <summary>
        /// Type of task we are performing. Different tasks have different underlying logic
        /// </summary>
        public TaskNodeType Type { get; set; }
        /// <summary>
        /// Bounds represents how close we must get to the node to complete it. 
        /// Some tasks require multiple actions within Bounds to be marked as complete.
        /// </summary>
        public int Bounds { get; set; }

        /// <summary>
        /// Counts the number of times the Task has been executed. Used for canceling invalid actions
        /// </summary>
        public int AttemptCount { get; set; }



        public TaskNode(Vector3 position, int bounds, TaskNodeType type = TaskNodeType.Movement)
        {
            WorldPosition = position;
            Type = type;
            Bounds = bounds;
        }
    }
}
