/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.btljava.dao.impl;

import com.btljava.daos.IBacSi;
import com.btljava.helper.DatabaseHelper;
import com.btljava.model.bacsi;
import com.btljava.model.nhanvien;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.util.ArrayList;
import java.util.List;

/**
 *
 * @author ASUS
 */
public class bacsiDao implements IBacSi{
     public boolean insert(bacsi nv) throws Exception{
        String sql = "insert into bacsi(manhanvien, hoten, ngaysinh, diachi, email, gioitinh, thanhtich, noicongtac, chucvu_id, ngayvao) values (?, ?, ?, ?, ?, ?, ?, ?, ?, ?)";
        try(
                Connection con = DatabaseHelper.getConnection();
                PreparedStatement stmt = con.prepareStatement(sql);
                ){
            stmt.setInt(1, nv.getManhanvien());
            stmt.setString(2, nv.getHoten());
            stmt.setString(3, nv.getNgaysinh());
            stmt.setString(4, nv.getDiachi());
            stmt.setString(5, nv.getEmail());
            stmt.setInt(6, nv.getGioitinh());
            stmt.setString(7, nv.getThanhtich());
            stmt.setString(8, nv.getNoicongtac());
            stmt.setInt(9, nv.getChucvu_id());
            stmt.setString(10, nv.getNgayvao());
            
            return stmt.executeUpdate() > 0;
        }
    }
    
    public boolean update(bacsi nv) throws Exception{
        String sql = "update bacsi set manhanvien = ?, hoten = ?, ngaysinh = ?, diachi = ?, email = ?, gioitinh = ?, thanhtich = ?, noicongtac = ?, chucvu_id = ?, ngayvao = ? where id = ?";
        try(
                Connection con = DatabaseHelper.getConnection();
                PreparedStatement stmt = con.prepareStatement(sql);
                ){
            stmt.setInt(1, nv.getManhanvien());
            stmt.setString(2, nv.getHoten());
            stmt.setString(3, nv.getNgaysinh());
            stmt.setString(4, nv.getDiachi());
            stmt.setString(5, nv.getEmail());
            stmt.setInt(6, nv.getGioitinh());
            stmt.setString(7, nv.getThanhtich());
            stmt.setString(8, nv.getNoicongtac());
            stmt.setInt(9, nv.getChucvu_id());
            stmt.setString(10, nv.getNgayvao());
            stmt.setInt(11, nv.getId());
            
            return stmt.executeUpdate() > 0;
        }
    }
    
    public boolean updates(bacsi nv) throws Exception{
        String sql = "update bacsi set hoten = ?, ngaysinh = ?, diachi = ?, email = ?, gioitinh = ?, thanhtich = ?, noicongtac = ?, chucvu_id = ?, ngayvao = ? where manhanvien = ?";
        try(
                Connection con = DatabaseHelper.getConnection();
                PreparedStatement stmt = con.prepareStatement(sql);
                ){
            stmt.setInt(10, nv.getManhanvien());
            stmt.setString(1, nv.getHoten());
            stmt.setString(2, nv.getNgaysinh());
            stmt.setString(3, nv.getDiachi());
            stmt.setString(4, nv.getEmail());
            stmt.setInt(5, nv.getGioitinh());
            stmt.setString(6, nv.getThanhtich());
            stmt.setString(7, nv.getNoicongtac());
            stmt.setInt(8, nv.getChucvu_id());
            stmt.setString(9, nv.getNgayvao());
            
            return stmt.executeUpdate() > 0;
        }
    }
    
    public boolean delete(String nv) throws Exception{
        String sql = "delete from bacsi where id = ?";
        try(
                Connection con = DatabaseHelper.getConnection();
                PreparedStatement stmt = con.prepareStatement(sql);
                ){
            stmt.setString(1, nv);
            
            return stmt.executeUpdate() > 0;
        }
    }
    public boolean deletes(String nv) throws Exception{
        String sql = "delete from bacsi where manhanvien = ?";
        try(
                Connection con = DatabaseHelper.getConnection();
                PreparedStatement stmt = con.prepareStatement(sql);
                ){
            stmt.setString(1, nv);
            
            return stmt.executeUpdate() > 0;
        }
    }
    
    
    public List<bacsi> fiindAll() throws Exception{
        String sql = "select * from bacsi";
        try(
                Connection con = DatabaseHelper.getConnection();
                PreparedStatement stmt = con.prepareStatement(sql);
                ){
            try(ResultSet rs = stmt.executeQuery();){
                List<bacsi> list = new ArrayList<>();
                while(rs.next()){
                    bacsi nv = new bacsi();
                    nv.setId(rs.getInt("id"));
                    nv.setManhanvien(rs.getInt("manhanvien"));
                    nv.setHoten(rs.getString("hoten"));
                    nv.setNgaysinh(rs.getString("ngaysinh"));
                    nv.setDiachi(rs.getString("diachi"));
                    nv.setEmail(rs.getString("email"));
                    nv.setGioitinh(rs.getInt("gioitinh"));
                    nv.setThanhtich(rs.getString("thanhtich"));
                    nv.setNoicongtac(rs.getString("noicongtac"));
                    nv.setChucvu_id(rs.getInt("chucvu_id"));
                    nv.setNgayvao(rs.getString("ngayvao"));
                    list.add(nv);
                }
                return list;
            }
        }
    }
    
    public List<bacsi> timkiem(String s) throws Exception{
        String sql = "select * from bacsi where hoten like N'%" + s + "%'";
        try(
                Connection con = DatabaseHelper.getConnection();
                PreparedStatement stmt = con.prepareStatement(sql);
                ){
            try(ResultSet rs = stmt.executeQuery();){
                List<bacsi> list = new ArrayList<>();
                while(rs.next()){
                    bacsi nv = new bacsi();
                    nv.setId(rs.getInt("id"));
                    nv.setManhanvien(rs.getInt("manhanvien"));
                    nv.setHoten(rs.getString("hoten"));
                    nv.setNgaysinh(rs.getString("ngaysinh"));
                    nv.setDiachi(rs.getString("diachi"));
                    nv.setEmail(rs.getString("email"));
                    nv.setGioitinh(rs.getInt("gioitinh"));
                    nv.setThanhtich(rs.getString("thanhtich"));
                    nv.setNoicongtac(rs.getString("noicongtac"));
                    nv.setChucvu_id(rs.getInt("chucvu_id"));
                    nv.setNgayvao(rs.getString("ngayvao"));
                    list.add(nv);
                }
                return list;
            }
        }
    }
    
    public bacsi findby(String id) throws Exception{
        String sql = "select * from bacsi where manhanvien = ?";
        try(
                Connection con = DatabaseHelper.getConnection();
                PreparedStatement stmt = con.prepareStatement(sql);
                ){
            stmt.setString(1, id);
            try(ResultSet rs = stmt.executeQuery();){
                if(rs.next()){
                    bacsi nv = new bacsi();
                    nv.setId(rs.getInt("id"));
                    nv.setManhanvien(rs.getInt("manhanvien"));
                    nv.setHoten(rs.getString("hoten"));
                    nv.setNgaysinh(rs.getString("ngaysinh"));
                    nv.setDiachi(rs.getString("diachi"));
                    nv.setEmail(rs.getString("email"));
                    nv.setGioitinh(rs.getInt("gioitinh"));
                    nv.setThanhtich(rs.getString("thanhtich"));
                    nv.setNoicongtac(rs.getString("noicongtac"));
                    nv.setChucvu_id(rs.getInt("chucvu_id"));
                    nv.setNgayvao(rs.getString("ngayvao"));
                    return nv;
                }
            }
            return null;
        }
    }
    
    public bacsi finbyid(int id) throws Exception{
        String sql = "select * from bacsi where id = ?";
        try(
                Connection con = DatabaseHelper.getConnection();
                PreparedStatement stmt = con.prepareStatement(sql);
                ){
            stmt.setInt(1, id);
            try(ResultSet rs = stmt.executeQuery();){
                if(rs.next()){
                    bacsi nv = new bacsi();
                    nv.setId(rs.getInt("id"));
                    nv.setManhanvien(rs.getInt("manhanvien"));
                    nv.setHoten(rs.getString("hoten"));
                    nv.setNgaysinh(rs.getString("ngaysinh"));
                    nv.setDiachi(rs.getString("diachi"));
                    nv.setEmail(rs.getString("email"));
                    nv.setGioitinh(rs.getInt("gioitinh"));
                    nv.setThanhtich(rs.getString("thanhtich"));
                    nv.setNoicongtac(rs.getString("noicongtac"));
                    nv.setChucvu_id(rs.getInt("chucvu_id"));
                    nv.setNgayvao(rs.getString("ngayvao"));
                    return nv;
                }
            }
            return null;
        }
    }
}
