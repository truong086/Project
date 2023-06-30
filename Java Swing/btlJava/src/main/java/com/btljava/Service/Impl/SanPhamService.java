/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.btljava.Service.Impl;

import com.btljava.Service.ISanPhamService;
import com.btljava.daos.ISanPham;
import com.btljava.dao.impl.sanphamDao;
import com.btljava.model.sanpham;
import java.util.List;

/**
 *
 * @author ASUS
 */
public class SanPhamService implements ISanPhamService{
    private ISanPham dao;
    
    public SanPhamService(){
        dao = new sanphamDao();
    }
    @Override
    public boolean insert(sanpham sp) throws Exception {
        return dao.insert(sp);
    }

    @Override
    public boolean update(sanpham sp) throws Exception {
        return dao.update(sp);
    }

    @Override
    public boolean delete(String sp) throws Exception {
        return dao.delete(sp);
    }

    @Override
    public List<sanpham> findAll() throws Exception {
        return dao.findAll();
    }

    @Override
    public List<sanpham> timkiem(String s) throws Exception {
        return dao.timkiem(s);
    }

    @Override
    public sanpham findby(int s) throws Exception {
        return dao.findby(s);
    }
    
}
