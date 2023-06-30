/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.btljava.dao.impl;

import com.btljava.daos.IYta;
import com.btljava.helper.DatabaseHelper;
import com.btljava.model.bacsi;
import com.btljava.model.nhanvien;
import com.btljava.model.yta;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.util.ArrayList;
import java.util.List;

/**
 *
 * @author ASUS
 */
public class ytaDao implements IYta{
    public boolean insert(yta nv) throws Exception{
        String sql = "insert into yta(manhanvien, hoten, ngaysinh, diachi, email, gioitinh, thanhtich, noicongtac, chucvu_id, ngayvao) values (?, ?, ?, ?, ?, ?, ?, ?, ?, ?)";
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
    
    public boolean update(yta nv) throws Exception{
        String sql = "update yta set manhanvien = ?, hoten = ?, ngaysinh = ?, diachi = ?, email = ?, gioitinh = ?, thanhtich = ?, noicongtac = ?, chucvu_id = ?, ngayvao = ? where id = ?";
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
    
    public boolean updates(yta nv) throws Exception{
        String sql = "update yta set hoten = ?, ngaysinh = ?, diachi = ?, email = ?, gioitinh = ?, thanhtich = ?, noicongtac = ?, chucvu_id = ?, ngayvao = ? where manhanvien = ?";
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
        String sql = "delete from yta where id = ?";
        try(
                Connection con = DatabaseHelper.getConnection();
                PreparedStatement stmt = con.prepareStatement(sql);
                ){
            stmt.setString(1, nv);
            
            return stmt.executeUpdate() > 0;
        }
    }
    
    public boolean deletes(String nv) throws Exception{
        String sql = "delete from yta where manhanvien = ?";
        try(
                Connection con = DatabaseHelper.getConnection();
                PreparedStatement stmt = con.prepareStatement(sql);
                ){
            stmt.setString(1, nv);
            
            return stmt.executeUpdate() > 0;
        }
    }
    
    public List<yta> fiindAll() throws Exception{
        String sql = "select * from yta";
        try(
                Connection con = DatabaseHelper.getConnection();
                PreparedStatement stmt = con.prepareStatement(sql);
                ){
            try(ResultSet rs = stmt.executeQuery();){
                List<yta> list = new ArrayList<>();
                while(rs.next()){
                    yta nv = new yta();
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
    
    public List<yta> timkiem(String s) throws Exception{
        String sql = "select * from yta where hoten like N'%" + s + "%'";
        try(
                Connection con = DatabaseHelper.getConnection();
                PreparedStatement stmt = con.prepareStatement(sql);
                ){
            try(ResultSet rs = stmt.executeQuery();){
                List<yta> list = new ArrayList<>();
                while(rs.next()){
                    yta nv = new yta();
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
    
    public yta findby(String id) throws Exception{
        String sql = "select * from yta where manhanvien = ?";
        try(
                Connection con = DatabaseHelper.getConnection();
                PreparedStatement stmt = con.prepareStatement(sql);
                ){
            stmt.setString(1, id);
            try(ResultSet rs = stmt.executeQuery();){
                if(rs.next()){
                    yta nv = new yta();
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
    
    public yta finbyid(int id) throws Exception{
        String sql = "select * from yta where id = ?";
        try(
                Connection con = DatabaseHelper.getConnection();
                PreparedStatement stmt = con.prepareStatement(sql);
                ){
            stmt.setInt(1, id);
            try(ResultSet rs = stmt.executeQuery();){
                if(rs.next()){
                    yta nv = new yta();
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
