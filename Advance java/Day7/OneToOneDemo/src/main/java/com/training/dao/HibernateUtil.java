package com.training.dao;

import org.hibernate.SessionFactory;
import org.hibernate.cfg.Configuration;

public class HibernateUtil {
	static SessionFactory sf=null;
	public static SessionFactory getMySessionFactory() {
		if(sf==null) {
			sf=new Configuration().configure().buildSessionFactory();
		}
		return sf;
	}
	public static void closeSessionFactory() {
		if(sf!=null) {
		 sf.close();
		}
	}

}
