/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.btljava.dao.impl;

import com.btljava.daos.IThacMac;
import com.btljava.helper.DatabaseHelper;
import com.btljava.model.phanhoi;
import com.btljava.model.thacmac;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.util.ArrayList;
import java.util.List;

/**
 *
 * @author ASUS
 */
public class thacmacDao implements IThacMac{
    public boolean insert(thacmac tm) throws Exception{
        String sql = "insert into thacmac(nguoigui_id, tieude, sodienthoai, email, diachi, noidung, ngaygui) values (?, ?, ?, ?, ?, ?, ?)";
        try(
                Connection con = DatabaseHelper.getConnection();
                PreparedStatement stmt = con.prepareStatement(sql);
                ){
            stmt.setInt(1, tm.getNguoigui_id());
            stmt.setString(2, tm.getTieude());
            stmt.setString(3, tm.getSodienthoai());
            stmt.setString(4, tm.getEmail());
            stmt.setString(5, tm.getDiachi());
            stmt.setString(6, tm.getNoidung());
            stmt.setString(7, tm.getNgaygui());
            return stmt.executeUpdate() > 0;
            
        }
        
        
    }
    
    public boolean update(thacmac tm) throws Exception{
        String sql = "update thacmac set nguoigui_id = ?, tieude = ?, sodienthoai = ?, email = ?, diachi = ?, noidung = ?, trangthai = ?, ngaygui = ? where id = ?";
        try(
                Connection con = DatabaseHelper.getConnection();
                PreparedStatement stmt = con.prepareStatement(sql);
                ){
            stmt.setInt(1, tm.getNguoigui_id());
            stmt.setString(2, tm.getTieude());
            stmt.setString(3, tm.getSodienthoai());
            stmt.setString(4, tm.getEmail());
            stmt.setString(5, tm.getDiachi());
            stmt.setString(6, tm.getNoidung());
            stmt.setString(7, tm.getTrangthai());
            stmt.setString(8, tm.getNgaygui());
            
            stmt.setInt(9, tm.getId());
            return stmt.executeUpdate() > 0;
            
        }
        
        
    }
    
    public boolean delete(String tm) throws Exception{
        String sql = "delete from thacmac where id = ?";
        try(
                Connection con = DatabaseHelper.getConnection();
                PreparedStatement stmt = con.prepareStatement(sql);
                ){
            stmt.setString(1, tm);
            
            return stmt.executeUpdate() > 0;
            
        }
        
        
    }
    
    public List<thacmac> findAll() throws Exception{
        String sql = "select * from thacmac";
        try(
                Connection con = DatabaseHelper.getConnection();
                PreparedStatement stmt = con.prepareStatement(sql);
                ){
            try(ResultSet rs = stmt.executeQuery();){
                List<thacmac> list = new ArrayList<>();
                while(rs.next()){
                    thacmac tm = new thacmac();
                    tm.setId(rs.getInt("id"));
                    tm.setNguoigui_id(rs.getInt("nguoigui_id"));
                    tm.setTieude(rs.getString("tieude"));
                    tm.setSodienthoai(rs.getString("sodienthoai"));
                    tm.setEmail(rs.getString("email"));
                    tm.setDiachi(rs.getString("diachi"));
                    tm.setNoidung(rs.getString("noidung"));
                    tm.setTrangthai(rs.getString("trangthai"));
                    tm.setNgaygui(rs.getString("ngaygui"));
                    list.add(tm);
                }
                return list;
            }
            
        }
        
        
    }
    
    public List<thacmac> deleteThacMac() throws Exception{
        String sql = "select * from thacmac where trangthai = 'duyet'";
        try(
                Connection con = DatabaseHelper.getConnection();
                PreparedStatement stmt = con.prepareStatement(sql);
                ){
            try(ResultSet rs = stmt.executeQuery();){
                List<thacmac> list = new ArrayList<>();
                while(rs.next()){
                    thacmac tm = new thacmac();
                    tm.setId(rs.getInt("id"));
                    tm.setNguoigui_id(rs.getInt("nguoigui_id"));
                    tm.setTieude(rs.getString("tieude"));
                    tm.setSodienthoai(rs.getString("sodienthoai"));
                    tm.setEmail(rs.getString("email"));
                    tm.setDiachi(rs.getString("diachi"));
                    tm.setNoidung(rs.getString("noidung"));
                    tm.setTrangthai(rs.getString("trangthai"));
                    tm.setNgaygui(rs.getString("ngaygui"));
                    list.add(tm);
                }
                return list;
            }
            
        }
        
        
    }
    
    public thacmac findbyid(int s) throws Exception{
        String sql = "select * from thacmac where id = ?";
        try(
                Connection con = DatabaseHelper.getConnection();
                PreparedStatement stmt = con.prepareStatement(sql);
                ){
            stmt.setInt(1, s);
            try(ResultSet rs = stmt.executeQuery();){
                if(rs.next()){
                    thacmac tm = new thacmac();
                    tm.setId(rs.getInt("id"));
                    tm.setNguoigui_id(rs.getInt("nguoigui_id"));
                    tm.setTieude(rs.getString("tieude"));
                    tm.setSodienthoai(rs.getString("sodienthoai"));
                    tm.setEmail(rs.getString("email"));
                    tm.setDiachi(rs.getString("diachi"));
                    tm.setNoidung(rs.getString("noidung"));
                    tm.setTrangthai(rs.getString("trangthai"));
                    tm.setNgaygui(rs.getString("ngaygui"));
                    return tm;
                }
                
            }
            return null;
            
        }
        
        
    }
    
    public List<thacmac> timkiem(String s) throws Exception{
        String sql = "select * from thacmac where nguoigui_id like N'%" + s + "%'";
        try(
                Connection con = DatabaseHelper.getConnection();
                PreparedStatement stmt = con.prepareStatement(sql);
                ){
            try(ResultSet rs = stmt.executeQuery();){
                List<thacmac> list = new ArrayList<>();
                while(rs.next()){
                    thacmac tm = new thacmac();
                    tm.setId(rs.getInt("id"));
                    tm.setNguoigui_id(rs.getInt("nguoigui_id"));
                    tm.setTieude(rs.getString("tieude"));
                    tm.setSodienthoai(rs.getString("sodienthoai"));
                    tm.setEmail(rs.getString("email"));
                    tm.setDiachi(rs.getString("diachi"));
                    tm.setNoidung(rs.getString("noidung"));
                    tm.setTrangthai(rs.getString("trangthai"));
                    tm.setNgaygui(rs.getString("ngaygui"));
                    list.add(tm);
                }
                return list;
            }
            
        }
        
        
    }
}
