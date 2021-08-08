package com.training.dao;

import java.sql.ResultSet;
import java.sql.SQLException;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.jdbc.core.JdbcTemplate;
import org.springframework.jdbc.core.RowMapper;
import org.springframework.stereotype.Repository;

import com.training.beans.MyUser;
@Repository
public class LoginDaoImpl implements LoginDao{
	@Autowired
	private JdbcTemplate jdbcTemplate;
	
	public boolean validateUser(String uname, String upass) {
		String sql="select * from user where username=? and password=?";
		MyUser u=jdbcTemplate.queryForObject(sql, new Object[] {uname,upass},new RowMapper<MyUser>() {
			public MyUser mapRow(ResultSet rs,int nrow) throws SQLException {
				MyUser u=new MyUser();
				u.setUname(rs.getString(1));
				u.setUpass(rs.getString(2));
				return u;
			}
		});
		if(u.getUname().equals(uname) && u.getUpass().equals(upass)) {
			return true;
		}
		else {
			return false;
		}
	}
	

}
