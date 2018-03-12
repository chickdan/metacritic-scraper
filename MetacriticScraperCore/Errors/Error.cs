﻿using System;
using MetacriticScraperCore.Interfaces;

namespace MetacriticScraperCore.Errors
{
    public class Error: IMetacriticData
    {
        public Error (Exception exception)
        {
            m_exception = exception.ToString();
            Message = exception.Message;
        }

        public Error (string message)
        {
            Message = message;
        }

        private string m_exception;
        public string Exception
        {
            get
            {
                if (!string.IsNullOrEmpty(m_exception))
                {
                    return m_exception.Substring(0, m_exception.IndexOf(':'));
                }
                return null;
            }
            set
            {
                m_exception = value;
            }
        }

        public string Message { get;}
    }
}
