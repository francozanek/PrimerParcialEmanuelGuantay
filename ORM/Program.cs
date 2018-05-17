/*
 * Created by SharpDevelop.
 * User: franco
 * Date: 31/7/2017
 * Time: 09:49
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;
using System.Collections.Generic;
using ORM.Codigos;
using ORM.Entities;
using ORM.Service;
using NHibernate.Cfg;
using NHibernate;
using System.Linq;

namespace ORM
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			//Con estas sentencias le decimos a la aplicación que use el archivo .cfg.xml 
		    Configuration cfg = new Configuration();
		    cfg.Configure("hibernate.cfg.xml");
		    //Sentencias utilizadas para crear la sesiones, a partir de la configuración de arriba y 
		    // para abrir la sesión con la que se va a trabajar en la aplicación
            ISessionFactory sessiones = cfg.BuildSessionFactory();
            ISession sesion = sessiones.OpenSession();
            
		}
	}
}
