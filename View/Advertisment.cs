using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View
{
    class Advertisment
    {
        private int video_id;
        public int Video_id
        {
            get
            {
                return video_id; 
            }
            set
            {
                video_id = value;
            }
        }
        private string video_name;
        public string Video_name
        {
            get
            {
                return video_name;
            }
            set
            {
                video_name = value;
            }
        }
        private string video_path;
        public string Video_path
        {
            get
            {
                return video_path;
            }
            set
            {
                video_path = value;
            }
        }
        private int priority;
        public int Priority
        {
            get
            {
                return priority;
            }
            set
            {
                priority = value;
            }
        }
        private int duration;
        public int Duration
        {
            get
            {
                return duration;
            }
            set
            {
                duration = value;
            }
        }
        private string status;
        public string Status
        {
            get
            {
                return status;
            }
            set
            {
                status = value;
            }
        }
    }
}
