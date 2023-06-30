/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.btljava.dao.impl;

import com.btljava.daos.IBenhNhan;
import com.btljava.helper.DatabaseHelper;
import com.btljava.model.benhnhan;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.util.ArrayList;
import java.util.List;

/**
 *
 * @author ASUS
 */
public class benhnhanDao implements IBenhNhan{
    public boolean insert(benhnhan bv) throws Exception{
        String sql = "insert into benhnhan(mabenhnhan, hoten, ngaysinh, diachi, gioitinh, nhommau, tinhtrang, chucvu_id, doituong_id, ngayvao) values (?, ?, ?, ?, ?, ?, ?, ?, ?, ?)";
        try(
                Connection con = DatabaseHelper.getConnection();
                PreparedStatement stmt = con.prepareStatement(sql);
                ){
            
            stmt.setInt(1, bv.getMabenhnhan());
            stmt.setString(2, bv.getHoten());
            stmt.setString(3, bv.getNgaysinh());
            stmt.setString(4, bv.getDiachi());
            stmt.setInt(5, bv.getGioitinh());
            stmt.setString(6, bv.getNhommau());
            stmt.setString(7, bv.getTinhtrang());
            stmt.setInt(8, bv.getChucvu_id());
            stmt.setInt(9, bv.getDoituong_id());
            stmt.setString(10, bv.getNgayvao());
            
            return stmt.executeUpdate() > 0;
            
        }
    }
    
    
    public boolean update(benhnhan bv) throws Exception{
        String sql = "update benhnhan set mabenhnhan = ?, hoten = ?, ngaysinh = ?, diachi = ?, gioitinh = ?, nhommau = ?, tinhtrang = ?, chucvu_id = ?, doituong_id = ?, ngayvao = ? where id = ?";
        try(
                Connection con = DatabaseHelper.getConnection();
                PreparedStatement stmt = con.prepareStatement(sql);
                ){
            
            stmt.setInt(1, bv.getMabenhnhan());
            stmt.setString(2, bv.getHoten());
            stmt.setString(3, bv.getNgaysinh());
            stmt.setString(4, bv.getDiachi());
            stmt.setInt(5, bv.getGioitinh());
            stmt.setString(6, bv.getNhommau());
            stmt.setString(7, bv.getTinhtrang());
            stmt.setInt(8, bv.getChucvu_id());
            stmt.setInt(9, bv.getDoituong_id());
            stmt.setString(10, bv.getNgayvao());
            stmt.setInt(11, bv.getId());
            
            return stmt.executeUpdate() > 0;
            
        }
    }
    
    public boolean updates(benhnhan bv) throws Exception{
        String sql = "update benhnhan set hoten = ?, ngaysinh = ?, diachi = ?, gioitinh = ?, nhommau = ?, tinhtrang = ?, chucvu_id = ?, doituong_id = ?, ngayvao = ? where mabenhnhan = ?";
        try(
                Connection con = DatabaseHelper.getConnection();
                PreparedStatement stmt = con.prepareStatement(sql);
                ){
            
            stmt.setInt(10, bv.getMabenhnhan());
            stmt.setString(1, bv.getHoten());
            stmt.setString(2, bv.getNgaysinh());
            stmt.setString(3, bv.getDiachi());
            stmt.setInt(4, bv.getGioitinh());
            stmt.setString(5, bv.getNhommau());
            stmt.setString(6, bv.getTinhtrang());
            stmt.setInt(7, bv.getChucvu_id());
            stmt.setInt(8, bv.getDoituong_id());
            stmt.setString(9, bv.getNgayvao());
            
            return stmt.executeUpdate() > 0;
            
        }
    }
    
    public boolean delete(String bv) throws Exception{
        String sql = "delete from benhnhan where id = ?";
        try(
                Connection con = DatabaseHelper.getConnection();
                PreparedStatement stmt = con.prepareStatement(sql);
                ){
            
            stmt.setString(1, bv);
            
            return stmt.executeUpdate() > 0;
            
        }
    }
    
    public boolean deletes(String bv) throws Exception{
        String sql = "delete from benhnhan where mabenhnhan = ?";
        try(
                Connection con = DatabaseHelper.getConnection();
                PreparedStatement stmt = con.prepareStatement(sql);
                ){
            
            stmt.setString(1, bv);
            
            return stmt.executeUpdate() > 0;
            
        }
    }
    
    public List<benhnhan> findAll() throws Exception{
        String sql = "select * from benhnhan";
        try(
                Connection con = DatabaseHelper.getConnection();
                PreparedStatement stmt = con.prepareStatement(sql);
                ){
            
            try(ResultSet rs = stmt.executeQuery();){
                List<benhnhan> list = new ArrayList<>();
                while(rs.next()){
                    benhnhan bv = new benhnhan();
                    bv.setId(rs.getInt("id"));
                    bv.setMabenhnhan(rs.getInt("mabenhnhan"));
                    bv.setHoten(rs.getString("hoten"));
                    bv.setNgaysinh(rs.getString("ngaysinh"));
                    bv.setDiachi(rs.getString("diachi"));
                    bv.setGioitinh(rs.getInt("gioitinh"));
                    bv.setNhommau(rs.getString("nhommau"));
                    bv.setTinhtrang(rs.getString("tinhtrang"));
                    bv.setChucvu_id(rs.getInt("chucvu_id"));
                    bv.setDoituong_id(rs.getInt("doituong_id"));
                    bv.setNgayvao(rs.getString("ngayvao"));
                    list.add(bv);
                }
                return list;
            }
            
        }
    }
    
    
    public List<benhnhan> banhnhancovid19() throws Exception{
        String sql = "select * from benhnhan inner join doituong on benhnhan.doituong_id = doituong.madoituong where doituong.madoituong = 3";
        try(
                Connection con = DatabaseHelper.getConnection();
                PreparedStatement stmt = con.prepareStatement(sql);
                ){
            
            try(ResultSet rs = stmt.executeQuery();){
                List<benhnhan> list = new ArrayList<>();
                while(rs.next()){
                    benhnhan bv = new benhnhan();
                    bv.setId(rs.getInt("benhnhan.id"));
                    bv.setMabenhnhan(rs.getInt("benhnhan.mabenhnhan"));
                    bv.setHoten(rs.getString("benhnhan.hoten"));
                    bv.setNgaysinh(rs.getString("benhnhan.ngaysinh"));
                    bv.setDiachi(rs.getString("benhnhan.diachi"));
                    bv.setGioitinh(rs.getInt("benhnhan.gioitinh"));
                    bv.setNhommau(rs.getString("benhnhan.nhommau"));
                    bv.setTinhtrang(rs.getString("benhnhan.tinhtrang"));
                    bv.setChucvu_id(rs.getInt("benhnhan.chucvu_id"));
                    bv.setDoituong_id(rs.getInt("benhnhan.doituong_id"));
                    bv.setNgayvao(rs.getString("benhnhan.ngayvao"));
                    list.add(bv);
                }
                return list;
            }
            
        }
    }
    
    public List<benhnhan> chuathanhtoan() throws Exception{
        String sql = "select * from benhnhan left join hoadon on benhnhan.mabenhnhan = hoadon.mabenhnhan where benhnhan.mabenhnhan not in (select mabenhnhan from hoadon)";
        try(
                Connection con = DatabaseHelper.getConnection();
                PreparedStatement stmt = con.prepareStatement(sql);
                ){
            
            try(ResultSet rs = stmt.executeQuery();){
                List<benhnhan> list = new ArrayList<>();
                while(rs.next()){
                    benhnhan bv = new benhnhan();
                    bv.setId(rs.getInt("benhnhan.id"));
                    bv.setMabenhnhan(rs.getInt("benhnhan.mabenhnhan"));
                    bv.setHoten(rs.getString("benhnhan.hoten"));
                    bv.setNgaysinh(rs.getString("benhnhan.ngaysinh"));
                    bv.setDiachi(rs.getString("benhnhan.diachi"));
                    bv.setGioitinh(rs.getInt("benhnhan.gioitinh"));
                    bv.setNhommau(rs.getString("benhnhan.nhommau"));
                    bv.setTinhtrang(rs.getString("benhnhan.tinhtrang"));
                    bv.setChucvu_id(rs.getInt("benhnhan.chucvu_id"));
                    bv.setDoituong_id(rs.getInt("benhnhan.doituong_id"));
                    bv.setNgayvao(rs.getString("benhnhan.ngayvao"));
                    list.add(bv);
                }
                return list;
            }
            
        }
    }
    
    
    public List<benhnhan> benhnhandacbiet() throws Exception{
        String sql = "select * from benhnhan inner join doituong on benhnhan.doituong_id = doituong.madoituong where doituong.madoituong = 2";
        try(
                Connection con = DatabaseHelper.getConnection();
                PreparedStatement stmt = con.prepareStatement(sql);
                ){
            
            try(ResultSet rs = stmt.executeQuery();){
                List<benhnhan> list = new ArrayList<>();
                while(rs.next()){
                    benhnhan bv = new benhnhan();
                    bv.setId(rs.getInt("benhnhan.id"));
                    bv.setMabenhnhan(rs.getInt("benhnhan.mabenhnhan"));
                    bv.setHoten(rs.getString("benhnhan.hoten"));
                    bv.setNgaysinh(rs.getString("benhnhan.ngaysinh"));
                    bv.setDiachi(rs.getString("benhnhan.diachi"));
                    bv.setGioitinh(rs.getInt("benhnhan.gioitinh"));
                    bv.setNhommau(rs.getString("benhnhan.nhommau"));
                    bv.setTinhtrang(rs.getString("benhnhan.tinhtrang"));
                    bv.setChucvu_id(rs.getInt("benhnhan.chucvu_id"));
                    bv.setDoituong_id(rs.getInt("benhnhan.doituong_id"));
                    bv.setNgayvao(rs.getString("benhnhan.ngayvao"));
                    list.add(bv);
                }
                return list;
            }
            
        }
    }
    
    public List<benhnhan> benhdichuyen() throws Exception{
        String sql = "select * from benhnhan inner join doituong on benhnhan.doituong_id = doituong.madoituong where doituong.madoituong = 10";
        try(
                Connection con = DatabaseHelper.getConnection();
                PreparedStatement stmt = con.prepareStatement(sql);
                ){
            
            try(ResultSet rs = stmt.executeQuery();){
                List<benhnhan> list = new ArrayList<>();
                while(rs.next()){
                    benhnhan bv = new benhnhan();
                    bv.setId(rs.getInt("benhnhan.id"));
                    bv.setMabenhnhan(rs.getInt("benhnhan.mabenhnhan"));
                    bv.setHoten(rs.getString("benhnhan.hoten"));
                    bv.setNgaysinh(rs.getString("benhnhan.ngaysinh"));
                    bv.setDiachi(rs.getString("benhnhan.diachi"));
                    bv.setGioitinh(rs.getInt("benhnhan.gioitinh"));
                    bv.setNhommau(rs.getString("benhnhan.nhommau"));
                    bv.setTinhtrang(rs.getString("benhnhan.tinhtrang"));
                    bv.setChucvu_id(rs.getInt("benhnhan.chucvu_id"));
                    bv.setDoituong_id(rs.getInt("benhnhan.doituong_id"));
                    bv.setNgayvao(rs.getString("benhnhan.ngayvao"));
                    list.add(bv);
                }
                return list;
            }
            
        }
    }
    
    public List<benhnhan> benhhiemgap() throws Exception{
        String sql = "select * from benhnhan inner join doituong on benhnhan.doituong_id = doituong.madoituong where doituong.madoituong = 11";
        try(
                Connection con = DatabaseHelper.getConnection();
                PreparedStatement stmt = con.prepareStatement(sql);
                ){
            
            try(ResultSet rs = stmt.executeQuery();){
                List<benhnhan> list = new ArrayList<>();
                while(rs.next()){
                    benhnhan bv = new benhnhan();
                    bv.setId(rs.getInt("benhnhan.id"));
                    bv.setMabenhnhan(rs.getInt("benhnhan.mabenhnhan"));
                    bv.setHoten(rs.getString("benhnhan.hoten"));
                    bv.setNgaysinh(rs.getString("benhnhan.ngaysinh"));
                    bv.setDiachi(rs.getString("benhnhan.diachi"));
                    bv.setGioitinh(rs.getInt("benhnhan.gioitinh"));
                    bv.setNhommau(rs.getString("benhnhan.nhommau"));
                    bv.setTinhtrang(rs.getString("benhnhan.tinhtrang"));
                    bv.setChucvu_id(rs.getInt("benhnhan.chucvu_id"));
                    bv.setDoituong_id(rs.getInt("benhnhan.doituong_id"));
                    bv.setNgayvao(rs.getString("benhnhan.ngayvao"));
                    list.add(bv);
                }
                return list;
            }
            
        }
    }
    public List<benhnhan> timkiem(String s) throws Exception{
        String sql = "select * from benhnhan where hoten like N'%" + s +"%'";
        try(
                Connection con = DatabaseHelper.getConnection();
                PreparedStatement stmt = con.prepareStatement(sql);
                ){
            
            try(ResultSet rs = stmt.executeQuery();){
                List<benhnhan> list = new ArrayList<>();
                while(rs.next()){
                    benhnhan bv = new benhnhan();
                    bv.setId(rs.getInt("id"));
                    bv.setMabenhnhan(rs.getInt("mabenhnhan"));
                    bv.setHoten(rs.getString("hoten"));
                    bv.setNgaysinh(rs.getString("ngaysinh"));
                    bv.setDiachi(rs.getString("diachi"));
                    bv.setGioitinh(rs.getInt("gioitinh"));
                    bv.setNhommau(rs.getString("nhommau"));
                    bv.setTinhtrang(rs.getString("tinhtrang"));
                    bv.setChucvu_id(rs.getInt("chucvu_id"));
                    bv.setDoituong_id(rs.getInt("doituong_id"));
                    bv.setNgayvao(rs.getString("ngayvao"));
                    list.add(bv);
                }
                return list;
            }
            
        }
    }
    
    
    public benhnhan findbyid(int n) throws Exception{
        String sql = "select * from benhnhan where id = ?";
        try(
                Connection con = DatabaseHelper.getConnection();
                PreparedStatement stmt = con.prepareStatement(sql);
                ){
            
            stmt.setInt(1, n);
            
            try(ResultSet rs = stmt.executeQuery();){
                if(rs.next()){
                    benhnhan bv = new benhnhan();
                    bv.setId(rs.getInt("id"));
                    bv.setMabenhnhan(rs.getInt("mabenhnhan"));
                    bv.setHoten(rs.getString("hoten"));
                    bv.setNgaysinh(rs.getString("ngaysinh"));
                    bv.setDiachi(rs.getString("diachi"));
                    bv.setGioitinh(rs.getInt("gioitinh"));
                    bv.setNhommau(rs.getString("nhommau"));
                    bv.setTinhtrang(rs.getString("tinhtrang"));
                    bv.setChucvu_id(rs.getInt("chucvu_id"));
                    bv.setDoituong_id(rs.getInt("doituong_id"));
                    bv.setNgayvao(rs.getString("ngayvao"));
                    return bv;
                }
                
            }
            return null;
            
        }
    }
    
    public benhnhan findby(String s) throws Exception{
        String sql = "select * from benhnhan where mabenhnhan = ?";
        try(
                Connection con = DatabaseHelper.getConnection();
                PreparedStatement stmt = con.prepareStatement(sql);
                ){
            
            stmt.setString(1, s);
            
            try(ResultSet rs = stmt.executeQuery();){
                if(rs.next()){
                    benhnhan bv = new benhnhan();
                    bv.setId(rs.getInt("id"));
                    bv.setMabenhnhan(rs.getInt("mabenhnhan"));
                    bv.setHoten(rs.getString("hoten"));
                    bv.setNgaysinh(rs.getString("ngaysinh"));
                    bv.setDiachi(rs.getString("diachi"));
                    bv.setGioitinh(rs.getInt("gioitinh"));
                    bv.setNhommau(rs.getString("nhommau"));
                    bv.setTinhtrang(rs.getString("tinhtrang"));
                    bv.setChucvu_id(rs.getInt("chucvu_id"));
                    bv.setDoituong_id(rs.getInt("doituong_id"));
                    bv.setNgayvao(rs.getString("ngayvao"));
                    return bv;
                }
                
            }
            return null;
            
        }
    }
    
}
