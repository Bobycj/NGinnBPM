﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace NGinnBPM.ProcessModel
{
    [DataContract(Name="CompositeTask")]
    public class CompositeTaskDef : TaskDef
    {
        public CompositeTaskDef()
        {
            Tasks = new List<TaskDef>();
            Places = new List<PlaceDef>();
            Flows = new List<FlowDef>();
        }

        [DataMember]
        public List<TaskDef> Tasks { get; set; }
        [DataMember]
        public List<PlaceDef> Places { get; set; }
        [DataMember]
        public List<FlowDef> Flows { get; set; }

        public override bool Validate(List<string> problemsFound)
        {
            return true;
        }
    }
}
