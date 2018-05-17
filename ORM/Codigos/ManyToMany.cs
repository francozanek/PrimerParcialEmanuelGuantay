/*
 * Created by SharpDevelop.
 * User: Franco
 * Date: 21/02/2018
 * Time: 11:11
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using NHibernate;
using ORM.Service;
using ORM.Entities;

namespace ORM.Codigos
{
	/// <summary>
	/// Description of ManyToMany.
	/// </summary>
	public class ManyToMany
	{
		ISession sesion;
		
		public ManyToMany(ISession session)
		{
			this.sesion = session;
		}
		
		
		public void AltaDesdeContacto(){
			ContactoServicio servicio = new ContactoServicio();
            servicio.setSesion(sesion);
            Email em= new Email();
            em.Estado="No leido";
            	List<Email> emails = new List<Email>();
            emails.Add(em);
            Contacto contacto = new Contacto();
            contacto.Descripcion="Juan";
        
            servicio.agregarContacto(contacto);
		}
		
		
		public void AltaDesdeEmail(){
			EmailServicio servicio = new EmailServicio();
            servicio.setSesion(sesion);
            Contacto cont1=new Contacto();
            cont1.Descripcion="Lucas";
            List<Contacto> contactos = new List<Contacto>();
            contactos.Add(cont1);
            Email email=new Email();
            email.Estado="Leido";
            email.Contactos=contactos;
            servicio.agregarEmail(email);
		}
		
		}
	
}
