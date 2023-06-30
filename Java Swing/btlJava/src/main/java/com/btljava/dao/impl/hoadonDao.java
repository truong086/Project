/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.btljava.dao.impl;

import com.btljava.daos.IHoaDon;
import com.btljava.helper.DatabaseHelper;
import com.btljava.model.hoadon;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.util.ArrayList;
import java.util.List;

/**
 *
 * @author ASUS
 */
public class hoadonDao implements IHoaDon{
    public boolean insert(hoadon hd) throws Exception{
        String sql = "insert into hoadon(mabenhnhan, ngayra, phuongphapdieutri, mieuta, thuoc_id, soluong, tongtienthuoc, tongtien, ngaytao) values (?, ?, ?, ?, ?, ?, ?, ?, ?)";
        
        try(
                Connection con = DatabaseHelper.getConnection();
                PreparedStatement stmt = con.prepareStatement(sql);
                ){
            
            stmt.setInt(1, hd.getMabenhnhan());
            stmt.setString(2, hd.getNgayra());
            stmt.setString(3, hd.getPhuongphapdieutri());
            stmt.setString(4, hd.getMieuta());
            stmt.setInt(5, hd.getThuoc_id());
            stmt.setInt(6, hd.getSoluong());
            stmt.setInt(7, hd.getTongtienthuoc());
            stmt.setInt(8, hd.getTongtien());
            stmt.setString(9, hd.getNgaytao());
            
            return stmt.executeUpdate() > 0;
        }
    }
    
    public boolean update(hoadon hd) throws Exception{
        String sql = "update hoadon set mabenhnhan = ?, ngayra = ?, phuongphapdieutri = ?, mieuta = ?, thuoc_id = ?, soluong = ?, tongtienthuoc = ?, tongtien = ?, ngaytao = ? where id = ?";
        
        try(
                Connection con = DatabaseHelper.getConnection();
                PreparedStatement stmt = con.prepareStatement(sql);
                ){
            
            stmt.setInt(1, hd.getMabenhnhan());
            stmt.setString(2, hd.getNgayra());
            stmt.setString(3, hd.getPhuongphapdieutri());
            stmt.setString(4, hd.getMieuta());
            stmt.setInt(5, hd.getThuoc_id());
            stmt.setInt(6, hd.getSoluong());
            stmt.setInt(7, hd.getTongtienthuoc());
            stmt.setInt(8, hd.getTongtien());
            stmt.setString(9, hd.getNgaytao());
            stmt.setInt(10, hd.getId());
            
            return stmt.executeUpdate() > 0;
        }
    }
    
    public boolean delete(String hd) throws Exception{
        String sql = "delete from hoadon where id = ?";
        
        try(
                Connection con = DatabaseHelper.getConnection();
                PreparedStatement stmt = con.prepareStatement(sql);
                ){
            
            stmt.setString(1, hd);
            
            return stmt.executeUpdate() > 0;
        }
    }
    
    public List<hoadon> findAll() throws Exception{
        String sql = "select * from hoadon";
        
        try(
                Connection con = DatabaseHelper.getConnection();
                PreparedStatement stmt = con.prepareStatement(sql);
                ){
            
            try(ResultSet rs = stmt.executeQuery();){
                List<hoadon> list = new ArrayList<>();
                while(rs.next()){
                    hoadon hd = new hoadon();
                    hd.setId(rs.getInt("id"));
                    hd.setMabenhnhan(rs.getInt("mabenhnhan"));
                    hd.setNgayra(rs.getString("ngayra"));
                    hd.setPhuongphapdieutri(rs.getString("phuongphapdieutri"));
                    hd.setMieuta(rs.getString("mieuta"));
                    hd.setThuoc_id(rs.getInt("thuoc_id"));
                    hd.setSoluong(rs.getInt("soluong"));
                    hd.setTongtienthuoc(rs.getInt("tongtienthuoc"));
                    hd.setTongtien(rs.getInt("tongtien"));
                    hd.setNgaytao(rs.getString("ngaytao"));
                    list.add(hd);
                }
                return list;
            }
        }
    }
    
    public List<hoadon> timkiem(String s) throws Exception{
        String sql = "select * from hoadon where mabenhnhan like N'%" + s + "%'";
        
        try(
                Connection con = DatabaseHelper.getConnection();
                PreparedStatement stmt = con.prepareStatement(sql);
                ){
            
            try(ResultSet rs = stmt.executeQuery();){
                List<hoadon> list = new ArrayList<>();
                while(rs.next()){
                    hoadon hd = new hoadon();
                    hd.setId(rs.getInt("id"));
                    hd.setMabenhnhan(rs.getInt("mabenhnhan"));
                    hd.setNgayra(rs.getString("ngayra"));
                    hd.setPhuongphapdieutri(rs.getString("phuongphapdieutri"));
                    hd.setMieuta(rs.getString("mieuta"));
                    hd.setThuoc_id(rs.getInt("thuoc_id"));
                    hd.setSoluong(rs.getInt("soluong"));
                    hd.setTongtienthuoc(rs.getInt("tongtienthuoc"));
                    hd.setTongtien(rs.getInt("tongtien"));
                    hd.setNgaytao(rs.getString("ngaytao"));
                    list.add(hd);
                }
                return list;
            }
        }
    }
    
    public hoadon findbyid(int s) throws Exception{
        String sql = "select * from hoadon where id = ?";
        
        try(
                Connection con = DatabaseHelper.getConnection();
                PreparedStatement stmt = con.prepareStatement(sql);
                ){
            
            stmt.setInt(1, s);
            
            try(ResultSet rs = stmt.executeQuery();){
                if(rs.next()){
                    hoadon hd = new hoadon();
                    hd.setId(rs.getInt("id"));
                    hd.setMabenhnhan(rs.getInt("mabenhnhan"));
                    hd.setNgayra(rs.getString("ngayra"));
                    hd.setPhuongphapdieutri(rs.getString("phuongphapdieutri"));
                    hd.setMieuta(rs.getString("mieuta"));
                    hd.setThuoc_id(rs.getInt("thuoc_id"));
                    hd.setSoluong(rs.getInt("soluong"));
                    hd.setTongtienthuoc(rs.getInt("tongtienthuoc"));
                    hd.setTongtien(rs.getInt("tongtien"));
                    hd.setNgaytao(rs.getString("ngaytao"));
                    return hd;
                }
                
            }
            return null;
        }
    }
    public List<hoadon> khachhang(String s) throws Exception{
        String sql = "select * from hoadon where mabenhnhan = ?";
        
        try(
                Connection con = DatabaseHelper.getConnection();
                PreparedStatement stmt = con.prepareStatement(sql);
                ){
            stmt.setString(1, s);
            try(ResultSet rs = stmt.executeQuery();){
                List<hoadon> list = new ArrayList<>();
                while(rs.next()){
                    hoadon hd = new hoadon();
                    hd.setId(rs.getInt("id"));
                    hd.setMabenhnhan(rs.getInt("mabenhnhan"));
                    hd.setNgayra(rs.getString("ngayra"));
                    hd.setPhuongphapdieutri(rs.getString("phuongphapdieutri"));
                    hd.setMieuta(rs.getString("mieuta"));
                    hd.setThuoc_id(rs.getInt("thuoc_id"));
                    hd.setSoluong(rs.getInt("soluong"));
                    hd.setTongtienthuoc(rs.getInt("tongtienthuoc"));
                    hd.setTongtien(rs.getInt("tongtien"));
                    hd.setNgaytao(rs.getString("ngaytao"));
                    list.add(hd);
                }
                return list;
            }
        }
    }
    
    public List<hoadon> sapxxep() throws Exception{
        String sql = "select * from hoadon order by tongtien asc";
        
        try(
                Connection con = DatabaseHelper.getConnection();
                PreparedStatement stmt = con.prepareStatement(sql);
                ){
            try(ResultSet rs = stmt.executeQuery();){
                List<hoadon> list = new ArrayList<>();
                while(rs.next()){
                    hoadon hd = new hoadon();
                    hd.setId(rs.getInt("id"));
                    hd.setMabenhnhan(rs.getInt("mabenhnhan"));
                    hd.setNgayra(rs.getString("ngayra"));
                    hd.setPhuongphapdieutri(rs.getString("phuongphapdieutri"));
                    hd.setMieuta(rs.getString("mieuta"));
                    hd.setThuoc_id(rs.getInt("thuoc_id"));
                    hd.setSoluong(rs.getInt("soluong"));
                    hd.setTongtienthuoc(rs.getInt("tongtienthuoc"));
                    hd.setTongtien(rs.getInt("tongtien"));
                    hd.setNgaytao(rs.getString("ngaytao"));
                    list.add(hd);
                }
                return list;
            }
        }
    }
}
