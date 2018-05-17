/*
 * Created by SharpDevelop.
 * User: usuario
 * Date: 17/5/2018
 * Time: 11:22 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using ORM.Repository;
using ORM.Entities;
using NHibernate;

namespace ORM.Service
{
	/// <summary>
	/// Description of EmailServicio.
	/// </summary>
	public class EmailServicio
	{
		private EmailRepositorio repo;
		
		public EmailServicio()
		{
			repo = new EmailRepositorio();
		}
		
		public void setSesion(ISession sesion){
			repo.setSession(sesion);
		}
		
		public void agregarEmail(Email art){
			repo.agregarEmail(art);
		}
		
		public void eliminarEmail(int id){
			repo.eliminarEmail(id);
		}
		
		
		public IList<Email>  listarTodos(){
			return repo.listarTodas();
		}
	}
}
