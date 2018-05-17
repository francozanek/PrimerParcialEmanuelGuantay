/*
 * Created by SharpDevelop.
 * User: usuario
 * Date: 17/5/2018
 * Time: 10:22 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System;
using System.Collections.Generic;
using NHibernate.Cfg;
using NHibernate;
using ORM.Entities;

namespace ORM.Repository
{
	/// <summary>
	/// Description of EmailRepositorio.
	/// </summary>
	public class EmailRepositorio
	{
		ISession sesion;
		
		public EmailRepositorio()
		{
		}
		
		public void setSession(ISession sesion){
			this.sesion = sesion;
		}
		
		public ISession getSessionFactory(){
			return sesion;
		}
		
		public void agregarEmail(Email email){
			getSessionFactory().SaveOrUpdate(email);
			getSessionFactory().Flush();
		}
		
		public void eliminarEmail(int id){
			IQuery query = getSessionFactory().CreateQuery("delete from Email where codigo = :id");
			query.SetParameter("id",id);
			query.ExecuteUpdate();
			getSessionFactory().Flush();
		}
		
	}
}
