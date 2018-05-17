/*
 * Created by SharpDevelop.
 * User: usuario
 * Date: 17/5/2018
 * Time: 10:29 a. m.
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
	/// Description of ContactoServicios.
	/// </summary>
	public class ContactoServicio
	{
		
		private ContactoRepositorio repo;
		
		public ContactoServicio()
		{
			repo = new ContactoRepositorio();
		}
		
		public void setSession(ISession sesion){
			repo.setSession(sesion);
		}
		
		public void agregarContacto(Contacto art){
			repo.agregarContacto(art);
		}
		
		
		public IList<Contacto>  listarTodos(){
			return repo.listarTodos();
		}
		
		public Contacto contactoPorId(int id){
			return repo.contactoPorID(id);
		}
		
	}
}
