/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.btljava.dao.impl;

import com.btljava.daos.IHoaDonNhap;
import com.btljava.helper.DatabaseHelper;
import com.btljava.model.hoadonnhap;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.util.ArrayList;
import java.util.List;

/**
 *
 * @author ASUS
 */
public class hoadonnhapDao implements IHoaDonNhap{
    public boolean insert(hoadonnhap hdn) throws Exception{
        String sql = "insert into hoadonnhap(tensanpham, maloai, gianhap, soluong, makho, nhanvien_id, ngaytao) values (?, ?, ?, ?, ?, ?, ?)";
        try(
                Connection con = DatabaseHelper.getConnection();
                PreparedStatement stmt = con.prepareStatement(sql);
                ){
            
            stmt.setString(1,hdn.getTensanpham());
            stmt.setInt(2,hdn.getMaloai());
            stmt.setInt(3,hdn.getGianhap());
            stmt.setInt(4,hdn.getSoliong());
            stmt.setInt(5,hdn.getMakho());
            stmt.setInt(6,hdn.getNhanvien_id());
            stmt.setString(7,hdn.getNgaytao());
            
            
            return stmt.executeUpdate() > 0;
        }
    }
    
    public boolean update(hoadonnhap hdn) throws Exception{
        String sql = "update hoadonnhap set tensanpham = ?, maloai = ?, gianhap = ?, soluong = ?, makho = ?, nhanvien_id = ?, ngaytao = ? where id = ?";
        try(
                Connection con = DatabaseHelper.getConnection();
                PreparedStatement stmt = con.prepareStatement(sql);
                ){
            
            stmt.setString(1,hdn.getTensanpham());
            stmt.setInt(2,hdn.getMaloai());
            stmt.setInt(3,hdn.getGianhap());
            stmt.setInt(4,hdn.getSoliong());
            stmt.setInt(5,hdn.getMakho());
            stmt.setInt(6,hdn.getNhanvien_id());
            stmt.setString(7,hdn.getNgaytao());
            stmt.setInt(8, hdn.getId());
            
            
            return stmt.executeUpdate() > 0;
        }
    }
    
    public boolean delete(String hdn) throws Exception{
        String sql = "delete from hoadonnhap where id = ?";
        try(
                Connection con = DatabaseHelper.getConnection();
                PreparedStatement stmt = con.prepareStatement(sql);
                ){
            
            stmt.setString(1, hdn);
            
            return stmt.executeUpdate() > 0;
        }
    }
    
    public List<hoadonnhap> findAll() throws Exception{
        String sql = "select * from hoadonnhap";
        try(
                Connection con = DatabaseHelper.getConnection();
                PreparedStatement stmt = con.prepareStatement(sql);
                ){
            
            try(ResultSet rs = stmt.executeQuery();){
                List<hoadonnhap> list = new ArrayList<>();
                while(rs.next()){
                    hoadonnhap hdn = new hoadonnhap();
                    hdn.setId(rs.getInt("id"));
                    hdn.setTensanpham(rs.getString("tensanpham"));
                    hdn.setMaloai(rs.getInt("maloai"));
                    hdn.setGianhap(rs.getInt("gianhap"));
                    hdn.setSoliong(rs.getInt("soluong"));
                    hdn.setMakho(rs.getInt("makho"));
                    hdn.setNhanvien_id(rs.getInt("nhanvien_id"));
                    hdn.setNgaytao(rs.getString("ngaytao"));
                    list.add(hdn);
                }
                return list;
            }
        }
    }
    
    public List<hoadonnhap> timkiem(String s) throws Exception{
        String sql = "select * from hoadonnhap where tensanpham like N'%" + s + "%'";
        try(
                Connection con = DatabaseHelper.getConnection();
                PreparedStatement stmt = con.prepareStatement(sql);
                ){
            
            try(ResultSet rs = stmt.executeQuery();){
                List<hoadonnhap> list = new ArrayList<>();
                while(rs.next()){
                    hoadonnhap hdn = new hoadonnhap();
                    hdn.setId(rs.getInt("id"));
                    hdn.setTensanpham(rs.getString("tensanpham"));
                    hdn.setMaloai(rs.getInt("maloai"));
                    hdn.setGianhap(rs.getInt("gianhap"));
                    hdn.setSoliong(rs.getInt("soluong"));
                    hdn.setMakho(rs.getInt("makho"));
                    hdn.setNhanvien_id(rs.getInt("nhanvien_id"));
                    hdn.setNgaytao(rs.getString("ngaytao"));
                    list.add(hdn);
                }
                return list;
            }
        }
    }
    
    public hoadonnhap findbyid(int s) throws Exception{
        String sql = "select * from hoadonnhap where id = ?";
        try(
                Connection con = DatabaseHelper.getConnection();
                PreparedStatement stmt = con.prepareStatement(sql);
                ){
            stmt.setInt(1, s);
            try(ResultSet rs = stmt.executeQuery();){
                if(rs.next()){
                    hoadonnhap hdn = new hoadonnhap();
                    hdn.setId(rs.getInt("id"));
                    hdn.setTensanpham(rs.getString("tensanpham"));
                    hdn.setMaloai(rs.getInt("maloai"));
                    hdn.setGianhap(rs.getInt("gianhap"));
                    hdn.setSoliong(rs.getInt("soluong"));
                    hdn.setMakho(rs.getInt("makho"));
                    hdn.setNhanvien_id(rs.getInt("nhanvien_id"));
                    hdn.setNgaytao(rs.getString("ngaytao"));
                    return hdn;
                }
                
            }
            return null;
        }
    }
}
