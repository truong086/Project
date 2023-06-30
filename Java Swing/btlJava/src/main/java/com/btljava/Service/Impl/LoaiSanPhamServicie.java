/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.btljava.Service.Impl;

import com.btljava.Service.ILoaiSanPhamService;
import com.btljava.daos.Iloaisanpham;
import com.btljava.dao.impl.loaisanphamDao;
import com.btljava.model.loaisanpham;
import java.util.List;

/**
 *
 * @author ASUS
 */
public class LoaiSanPhamServicie implements ILoaiSanPhamService{
    private Iloaisanpham dao;
    
    public LoaiSanPhamServicie(){
        dao = new loaisanphamDao();
    }
    
    @Override
    public boolean insert(loaisanpham lsp) throws Exception {
        return dao.insert(lsp);
    }

    @Override
    public boolean update(loaisanpham lsp) throws Exception {
        return dao.update(lsp);
    }

    @Override
    public boolean delete(String lsp) throws Exception {
        return dao.delete(lsp);
    }

    @Override
    public List<loaisanpham> findAll() throws Exception {
        return dao.findAll();
    }

    @Override
    public List<loaisanpham> finbyid(String s) throws Exception {
        return dao.finbyid(s);
    }

    @Override
    public loaisanpham finbyids(int s) throws Exception {
        return dao.finbyids(s);
    }
    
}
