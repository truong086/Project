/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.btljava.dao.impl;

import com.btljava.daos.INhanVien;
import com.btljava.helper.DatabaseHelper;
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
public class nhanvienDao implements INhanVien{
    public boolean insert(nhanvien nv) throws Exception{
        String sql = "insert into nhanvien(manhanvien, hoten, ngaysinh, diachi, email, gioitinh, thanhtich, noicongtac, chucvu_id, ngayvao) values (?, ?, ?, ?, ?, ?, ?, ?, ?, ?)";
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
    
    public boolean update(nhanvien nv) throws Exception{
        String sql = "update nhanvien set manhanvien = ?, hoten = ?, ngaysinh = ?, diachi = ?, email = ?, gioitinh = ?, thanhtich = ?, noicongtac = ?, chucvu_id = ?, ngayvao = ? where id = ?";
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
    
    public boolean updates(nhanvien nv) throws Exception{
        String sql = "update nhanvien set hoten = ?, ngaysinh = ?, diachi = ?, email = ?, gioitinh = ?, thanhtich = ?, noicongtac = ?, chucvu_id = ?, ngayvao = ? where manhanvien = ?";
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
        String sql = "delete from nhanvien where id = ?";
        try(
                Connection con = DatabaseHelper.getConnection();
                PreparedStatement stmt = con.prepareStatement(sql);
                ){
            stmt.setString(1, nv);
            
            return stmt.executeUpdate() > 0;
        }
    }
    
    public boolean deletes(String nv) throws Exception{
        String sql = "delete from nhanvien where manhanvien = ?";
        try(
                Connection con = DatabaseHelper.getConnection();
                PreparedStatement stmt = con.prepareStatement(sql);
                ){
            stmt.setString(1, nv);
            
            return stmt.executeUpdate() > 0;
        }
    }
    
    public List<nhanvien> fiindAll() throws Exception{
        String sql = "select * from nhanvien";
        try(
                Connection con = DatabaseHelper.getConnection();
                PreparedStatement stmt = con.prepareStatement(sql);
                ){
            try(ResultSet rs = stmt.executeQuery();){
                List<nhanvien> list = new ArrayList<>();
                while(rs.next()){
                    nhanvien nv = new nhanvien();
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
    
    public List<nhanvien> timkiem(String s) throws Exception{
        String sql = "select * from nhanvien where hoten like N'%" + s + "%'";
        try(
                Connection con = DatabaseHelper.getConnection();
                PreparedStatement stmt = con.prepareStatement(sql);
                ){
            try(ResultSet rs = stmt.executeQuery();){
                List<nhanvien> list = new ArrayList<>();
                while(rs.next()){
                    nhanvien nv = new nhanvien();
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
    
    public nhanvien findby(String id) throws Exception{
        String sql = "select * from nhanvien where manhanvien = ?";
        try(
                Connection con = DatabaseHelper.getConnection();
                PreparedStatement stmt = con.prepareStatement(sql);
                ){
            stmt.setString(1, id);
            try(ResultSet rs = stmt.executeQuery();){
                if(rs.next()){
                    nhanvien nv = new nhanvien();
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
    
    public nhanvien finbyid(int id) throws Exception{
        String sql = "select * from nhanvien where id = ?";
        try(
                Connection con = DatabaseHelper.getConnection();
                PreparedStatement stmt = con.prepareStatement(sql);
                ){
            stmt.setInt(1, id);
            try(ResultSet rs = stmt.executeQuery();){
                if(rs.next()){
                    nhanvien nv = new nhanvien();
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

    @Override
    public List<nhanvien> chucvu(int chucvu) throws Exception {
        String sql = "select * from chucvu as cv inner join nhanvien as nv on cv.machucvu = nv.chucvu_id inner join tienluong as tl on tl.matienluong = cv.tienluong_id where nv.chucvu_id = ?";
        try(
                Connection con = DatabaseHelper.getConnection();
                PreparedStatement stmt = con.prepareStatement(sql);
                ){
            stmt.setInt(1, chucvu);
            try(ResultSet rs = stmt.executeQuery();){
                List<nhanvien> list = new ArrayList<>();
                while(rs.next()){
                    nhanvien nv = new nhanvien();
                    nv.setId(rs.getInt("nv.id"));
                    nv.setManhanvien(rs.getInt("nv.manhanvien"));
                    nv.setHoten(rs.getString("nv.hoten"));
                    nv.setNgaysinh(rs.getString("nv.ngaysinh"));
                    nv.setDiachi(rs.getString("nv.diachi"));
                    nv.setEmail(rs.getString("nv.email"));
                    nv.setGioitinh(rs.getInt("nv.gioitinh"));
                    nv.setThanhtich(rs.getString("nv.thanhtich"));
                    nv.setNoicongtac(rs.getString("nv.noicongtac"));
                    nv.setChucvu_id(rs.getInt("nv.chucvu_id"));
                    nv.setNgayvao(rs.getString("nv.ngayvao"));
                    
                    nv.setIds(rs.getInt("cv.id"));
                    nv.setMachucvu(rs.getInt("cv.machucvu"));
                    nv.setTenchucvu(rs.getString("cv.tenchucvu"));
                    nv.setNgaytao(rs.getString("cv.ngaytao"));
                    nv.setTienluong_id(rs.getInt("cv.tienluong_id"));
                    nv.setKhenthuong(rs.getInt("cv.khenthuong"));
                    
                    
                    nv.setIdss(rs.getInt("tl.id"));
                    nv.setMatienluong(rs.getInt("tl.matienluong"));
                    nv.setTienluong(rs.getInt("tl.tienluong"));
                    nv.setNgaycong(rs.getInt("tl.ngaycong"));
                    nv.setNgaytaos(rs.getString("tl.ngaytao"));
                    
                    list.add(nv);
                }
                return list;
            }
            
            
        }
    }
}
