/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.btljava.dao.impl;

import com.btljava.daos.ILoaiGiuong;
import com.btljava.helper.DatabaseHelper;
import com.btljava.model.loaigiuong;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.util.ArrayList;
import java.util.List;

/**
 *
 * @author ASUS
 */
public class loaigiuongDao implements ILoaiGiuong{
    public boolean insert(loaigiuong lg) throws Exception{
        String sql = "insert into loaigiuong(tengiuong, soluong, ngaytao) values (?, ?, ?)";
        try(
                Connection con = DatabaseHelper.getConnection();
                PreparedStatement stmt = con.prepareStatement(sql);
                ){
            
            stmt.setString(1, lg.getTengiuong());
            stmt.setInt(2, lg.getSoluong());
            stmt.setString(3, lg.getNgaytao());
            
            return stmt.executeUpdate() > 0;
            
        }
    }
    
    public boolean update(loaigiuong lg) throws Exception{
        String sql = "update loaigiuong set tengiuong = ?, soluong = ?, ngaytao = ? where id = ?";
        try(
                Connection con = DatabaseHelper.getConnection();
                PreparedStatement stmt = con.prepareStatement(sql);
                ){
            
            stmt.setString(1, lg.getTengiuong());
            stmt.setInt(2, lg.getSoluong());
            stmt.setString(3, lg.getNgaytao());
            stmt.setInt(4, lg.getId());
            
            return stmt.executeUpdate() > 0;
            
        }
    }
    
    public boolean delete(String lg) throws Exception{
        String sql = "delete from loaigiuong where id = ?";
        try(
                Connection con = DatabaseHelper.getConnection();
                PreparedStatement stmt = con.prepareStatement(sql);
                ){
            
            stmt.setString(1, lg);
            
            return stmt.executeUpdate() > 0;
            
        }
    }
    
    public List<loaigiuong> findAll() throws Exception{
        String sql = "select * from loaigiuong";
        try(
                Connection con = DatabaseHelper.getConnection();
                PreparedStatement stmt = con.prepareStatement(sql);
                ){
            
            try(ResultSet rs = stmt.executeQuery();){
                List<loaigiuong> list = new ArrayList<>();
                while(rs.next()){
                    loaigiuong lg = new loaigiuong();
                    lg.setId(rs.getInt("id"));
                    lg.setTengiuong(rs.getString("tengiuong"));
                    lg.setSoluong(rs.getInt("soluong"));
                    lg.setNgaytao(rs.getString("ngaytao"));
                    list.add(lg);
                }
                return list;
            }
            
        }
    }
    
    public loaigiuong findAllid(int id) throws Exception{
        String sql = "select * from loaigiuong where id = ?";
        try(
                Connection con = DatabaseHelper.getConnection();
                PreparedStatement stmt = con.prepareStatement(sql);
                ){
            
            stmt.setInt(1, id);
            
            try(ResultSet rs = stmt.executeQuery();){
                if(rs.next()){
                    loaigiuong lg = new loaigiuong();
                    lg.setId(rs.getInt("id"));
                    lg.setTengiuong(rs.getString("tengiuong"));
                    lg.setSoluong(rs.getInt("soluong"));
                    lg.setNgaytao(rs.getString("ngaytao"));
                    return lg;
                }
                
            }
            return null;
            
        }
    }
    
    public List<loaigiuong> timkiem(String s) throws Exception{
        String sql = "select * from loaigiuong where tengiuong like N'%" + s + "%'";
        try(
                Connection con = DatabaseHelper.getConnection();
                PreparedStatement stmt = con.prepareStatement(sql);
                ){
            
            try(ResultSet rs = stmt.executeQuery();){
                List<loaigiuong> list = new ArrayList<>();
                while(rs.next()){
                    loaigiuong lg = new loaigiuong();
                    lg.setId(rs.getInt("id"));
                    lg.setTengiuong(rs.getString("tengiuong"));
                    lg.setSoluong(rs.getInt("soluong"));
                    lg.setNgaytao(rs.getString("ngaytao"));
                    list.add(lg);
                }
                return list;
            }
            
        }
    }
}
