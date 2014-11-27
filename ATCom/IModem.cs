using System;
using System.Collections.Generic;
using System.Text;

namespace ATCom
{
    interface IModem
    {
        /// <summary>
        /// Connect to model
        /// </summary>
        /// <returns></returns>
        bool Connect();
        /// <summary>
        /// Disconnect from model
        /// </summary>
        /// <returns></returns>
        bool Disconnect();
        /// <summary>
        /// Call using AT Commands.
        /// </summary>
        /// <param name="phoneNumber"></param>
        void Call(string phoneNumber);
        /// <summary>
        /// Send SMS
        /// </summary>
        /// <param name="phoneNumber"></param>
        /// <param name="textMessage"></param>
        void Send(string phoneNumber, string textMessage);
    }
}
