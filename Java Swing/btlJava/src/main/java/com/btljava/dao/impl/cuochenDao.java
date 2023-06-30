/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.btljava.dao.impl;

import com.btljava.daos.ICuocHen;
import com.btljava.helper.DatabaseHelper;
import com.btljava.model.cuochen;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.util.ArrayList;
import java.util.List;

/**
 *
 * @author ASUS
 */
public class cuochenDao implements ICuocHen{
    public boolean insert(cuochen ch) throws Exception{
        String sql = "insert into cuochen(bacsi, benhnhan, noidung, thoigian) values (?, ?, ?, ?)";
        try(
                Connection con = DatabaseHelper.getConnection();
                PreparedStatement stmt = con.prepareStatement(sql);
                ){
            stmt.setString(1, ch.getBacssi());
            stmt.setString(2, ch.getBenhnhan());
            stmt.setString(3, ch.getNoidung());
            stmt.setString(4, ch.getThoigian());
            
            return stmt.executeUpdate() > 0;
        }
    }
    
    public boolean update(cuochen ch) throws Exception{
        String sql = "update cuochen set bacsi = ?, benhnhan = ?, noidung = ?, thoigian = ? where id = ?";
        try(
                Connection con = DatabaseHelper.getConnection();
                PreparedStatement stmt = con.prepareStatement(sql);
                ){
            stmt.setString(1, ch.getBacssi());
            stmt.setString(2, ch.getBenhnhan());
            stmt.setString(3, ch.getNoidung());
            stmt.setString(4, ch.getThoigian());
            stmt.setInt(5, ch.getId());
            
            return stmt.executeUpdate() > 0;
        }
    }
    
    public boolean delete(String ch) throws Exception{
        String sql = "delete from cuochen where id = ?";
        try(
                Connection con = DatabaseHelper.getConnection();
                PreparedStatement stmt = con.prepareStatement(sql);
                ){
            stmt.setString(1, ch);
            
            return stmt.executeUpdate() > 0;
        }
    }
    
    public List<cuochen> findAll() throws Exception{
        String sql = "select * from cuochen";
        try(
                Connection con = DatabaseHelper.getConnection();
                PreparedStatement stmt = con.prepareStatement(sql);
                ){
            try(ResultSet rs = stmt.executeQuery();){
                List<cuochen> list = new ArrayList<>();
                while(rs.next()){
                    cuochen ch = new cuochen();
                    ch.setId(rs.getInt("id"));
                    ch.setBacssi(rs.getString("bacsi"));
                    ch.setBenhnhan(rs.getString("benhnhan"));
                    ch.setNoidung(rs.getString("noidung"));
                    ch.setThoigian(rs.getString("thoigian"));
                    list.add(ch);
                }
                return list;
            }
        }
    }
    
    public List<cuochen> timkiem(String s) throws Exception{
        String sql = "select * from cuochen where bacsi like N'%" + s + "%' or benhnhan like N'%" + s + "%'";
        try(
                Connection con = DatabaseHelper.getConnection();
                PreparedStatement stmt = con.prepareStatement(sql);
                ){
            try(ResultSet rs = stmt.executeQuery();){
                List<cuochen> list = new ArrayList<>();
                while(rs.next()){
                    cuochen ch = new cuochen();
                    ch.setId(rs.getInt("id"));
                    ch.setBacssi(rs.getString("bacsi"));
                    ch.setBenhnhan(rs.getString("benhnhan"));
                    ch.setNoidung(rs.getString("noidung"));
                    ch.setThoigian(rs.getString("thoigian"));
                    list.add(ch);
                }
                return list;
            }
        }
    }
    
    public cuochen findbyid(int s) throws Exception{
        String sql = "select * from cuochen where id = ?";
        try(
                Connection con = DatabaseHelper.getConnection();
                PreparedStatement stmt = con.prepareStatement(sql);
                ){
            
            stmt.setInt(1, s);
            try(ResultSet rs = stmt.executeQuery();){
                if(rs.next()){
                    cuochen ch = new cuochen();
                    ch.setId(rs.getInt("id"));
                    ch.setBacssi(rs.getString("bacsi"));
                    ch.setBenhnhan(rs.getString("benhnhan"));
                    ch.setNoidung(rs.getString("noidung"));
                    ch.setThoigian(rs.getString("thoigian"));
                    return ch;
                }
                
            }
            
            return null;
        }
    }
}
