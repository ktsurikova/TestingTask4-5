﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;

namespace Framework.Logging
{
    /// <summary>
    /// class for working with NLog
    /// </summary>
    public class NLogger : ILogger
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();

        /// <summary>
        /// writes debug info
        /// </summary>
        /// <param name="time">time</param>
        /// <param name="message">main message</param>
        /// <param name="additionalInfo">additional information</param>
        public void Debug(DateTime time, string message, string additionalInfo = null)
        {
            logger.Info("DEBUG");
            logger.Info(time);
            logger.Debug(message);
            if (additionalInfo != null)
                logger.Debug(additionalInfo);
        }

        /// <summary>
        /// writes info
        /// </summary>
        /// <param name="time">time</param>
        /// <param name="message">main message</param>
        /// <param name="additionalInfo">additional information</param>
        public void Info(DateTime time, string message, string additionalInfo = null)
        {
            logger.Info("INFO");
            logger.Info(time);
            logger.Info(message);
            if (additionalInfo != null)
                logger.Info(additionalInfo);
        }

        /// <summary>
        /// writes warnings
        /// </summary>
        /// <param name="time">time</param>
        /// <param name="message">main message</param>
        /// <param name="additionalInfo">additional information</param>
        public void Warn(DateTime time, string message, string additionalInfo = null)
        {
            logger.Info("WARNING");
            logger.Info(time);
            logger.Warn(message);
            if (additionalInfo != null)
                logger.Warn(additionalInfo);
        }

        /// <summary>
        /// writes errors
        /// </summary>
        /// <param name="time">time</param>
        /// <param name="message">main message</param>
        /// <param name="additionalInfo">additional information</param>
        public void Error(DateTime time, string message, string additionalInfo = null)
        {
            logger.Info("ERROR");
            logger.Info(time);
            logger.Error(message);
            if (additionalInfo != null)
                logger.Error(additionalInfo);
        }

        /// <summary>
        /// writes fatal errors
        /// </summary>
        /// <param name="time">time</param>
        /// <param name="message">main message</param>
        /// <param name="additionalInfo">additional information</param>
        public void Fatal(DateTime time, string message, string additionalInfo = null)
        {
            logger.Info("FATAL");
            logger.Info(time);
            logger.Fatal(message);
            if (additionalInfo != null)
                logger.Fatal(additionalInfo);
        }
    }
}
