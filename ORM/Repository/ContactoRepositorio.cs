/*
 * Created by SharpDevelop.
 * User: usuario
 * Date: 17/5/2018
 * Time: 10:22 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using NHibernate.Cfg;
using NHibernate;
using ORM.Entities;

namespace ORM.Repository
{
	/// <summary>
	/// Description of ContactoRepositorio.
	/// </summary>
	public class ContactoRepositorio
	{
		ISession sesion;
		
		
		public ContactoRepositorio()
		{
		}
		
		public void setSession(ISession sesion){
			this.sesion = sesion;
		}
		
		public ISession getSessionFactory(){
			return this.sesion;
		}
		
		public void agregarContacto(Contacto art){
			getSessionFactory().SaveOrUpdate(art);
			getSessionFactory().Flush();
		}
		
		public IList<Contacto>  listarTodos(){
			IList<Contacto> lista1 = getSessionFactory().CreateQuery("from Contacto c")
                .List<Contacto>();
			
			return lista1;
		}
		
		public Contacto contactoPorID(int id){
			IQuery query = getSessionFactory().CreateQuery("from contacto where cod_contacto = :id");
			query.SetParameter("id",id);
			Contacto contacto = query.UniqueResult<Contacto>();
			
			return contacto;
		}
		
	}
}
