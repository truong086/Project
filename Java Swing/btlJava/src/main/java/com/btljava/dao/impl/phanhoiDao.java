/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.btljava.dao.impl;

import com.btljava.daos.IPhanHoi;
import com.btljava.helper.DatabaseHelper;
import com.btljava.model.phanhoi;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.util.ArrayList;
import java.util.List;

/**
 *
 * @author ASUS
 */
public class phanhoiDao implements IPhanHoi{
    public boolean insert(phanhoi ph) throws Exception{
        String sql = "insert into phanhoi(nguoigui_id, nguoinhan_id, tieude, chucvu, noidung, ngaygui) values (?, ?, ?, ?, ?, ?)";
        
        try(
                Connection con = DatabaseHelper.getConnection();
                PreparedStatement stmt = con.prepareStatement(sql);
                ){
            
            stmt.setInt(1, ph.getNguoigui_id());
            stmt.setInt(2, ph.getNguoinhan_id());
            stmt.setString(3, ph.getTieude());
            stmt.setString(4, ph.getChucvu());
            stmt.setString(5, ph.getNoidung());
            stmt.setString(6, ph.getNgaygui());
            
            return stmt.executeUpdate() > 0;
        }
    }
    
    public boolean update(phanhoi ph) throws Exception{
        String sql = "update phanhoi set nguoigui_id = ?, nguoinhan_id = ?, tieude = ?, chucvu = ?, noidung = ?, ngaygui = ? where id = ?";
        
        try(
                Connection con = DatabaseHelper.getConnection();
                PreparedStatement stmt = con.prepareStatement(sql);
                ){
            
            stmt.setInt(1, ph.getNguoigui_id());
            stmt.setInt(2, ph.getNguoinhan_id());
            stmt.setString(3, ph.getTieude());
            stmt.setString(4, ph.getChucvu());
            stmt.setString(5, ph.getNoidung());
            stmt.setString(6, ph.getNgaygui());
            stmt.setInt(7, ph.getId());
            
            return stmt.executeUpdate() > 0;
        }
    }
    
    public boolean delete(String ph) throws Exception{
        String sql = "delete from phanhoi where id = ?";
        
        try(
                Connection con = DatabaseHelper.getConnection();
                PreparedStatement stmt = con.prepareStatement(sql);
                ){
            
            stmt.setString(1, ph);
            
            return stmt.executeUpdate() > 0;
        }
    }
    
    public List<phanhoi> findAll(int s) throws Exception{
        String sql = "select * from phanhoi where nguoinhan_id = ?";
        
        try(
                Connection con = DatabaseHelper.getConnection();
                PreparedStatement stmt = con.prepareStatement(sql);
                ){
            
            stmt.setInt(1, s);
            try(ResultSet rs = stmt.executeQuery();){
                List<phanhoi> list = new ArrayList<>();
                while(rs.next()){
                    phanhoi ph = new phanhoi();
                    ph.setId(rs.getInt("id"));
                    ph.setNguoigui_id(rs.getInt("nguoigui_id"));
                    ph.setNguoinhan_id(rs.getInt("nguoinhan_id"));
                    ph.setTieude(rs.getString("tieude"));
                    ph.setChucvu(rs.getString("chucvu"));
                    ph.setNoidung(rs.getString("noidung"));
                    ph.setNgaygui(rs.getString("ngaygui"));
                    list.add(ph);
                }
                
                return list;
                
            }
        }
    }
    
    public phanhoi findbyid(int s) throws Exception{
        String sql = "select * from phanhoi where id = ?";
        
        try(
                Connection con = DatabaseHelper.getConnection();
                PreparedStatement stmt = con.prepareStatement(sql);
                ){
            
            stmt.setInt(1, s);
            try(ResultSet rs = stmt.executeQuery();){
                if(rs.next()){
                    phanhoi ph = new phanhoi();
                    ph.setId(rs.getInt("id"));
                    ph.setNguoigui_id(rs.getInt("nguoigui_id"));
                    ph.setNguoinhan_id(rs.getInt("nguoinhan_id"));
                    ph.setTieude(rs.getString("tieude"));
                    ph.setChucvu(rs.getString("chucvu"));
                    ph.setNoidung(rs.getString("noidung"));
                    ph.setNgaygui(rs.getString("ngaygui"));
                    return ph;
                }
                
                
                
            }
            return null;
        }
    }
    
    public List<phanhoi> timkiem(String s) throws Exception{
        String sql = "select * from phanhoi where nguoigui_id like N'%" + s + "%'";
        
        try(
                Connection con = DatabaseHelper.getConnection();
                PreparedStatement stmt = con.prepareStatement(sql);
                ){
            
            try(ResultSet rs = stmt.executeQuery();){
                List<phanhoi> list = new ArrayList<>();
                while(rs.next()){
                    phanhoi ph = new phanhoi();
                    ph.setId(rs.getInt("id"));
                    ph.setNguoigui_id(rs.getInt("nguoigui_id"));
                    ph.setNguoinhan_id(rs.getInt("nguoinhan_id"));
                    ph.setTieude(rs.getString("tieude"));
                    ph.setChucvu(rs.getString("chucvu"));
                    ph.setNoidung(rs.getString("noidung"));
                    ph.setNgaygui(rs.getString("ngaygui"));
                    list.add(ph);
                }
                
                return list;
                
            }
        }
    }
}
