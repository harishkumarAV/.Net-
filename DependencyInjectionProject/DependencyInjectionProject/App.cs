using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DependencyInjectionProject.Interfaces;

namespace DependencyInjectionProject
{
    public class App
    {
        public readonly IMessageWriter _messageWriter;
        public App(IMessageWriter messageWriter) {
            _messageWriter = messageWriter;
        }
        public void run()
        {
            string message = "Hey!";
            _messageWriter.Write(message);
        }
    }
}
