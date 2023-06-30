/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.btljava.Service.Impl;

import com.btljava.Service.INhaTaiTroService;
import com.btljava.daos.INhaTaiTro;
import com.btljava.dao.impl.nhataitroDao;
import com.btljava.model.nhataitro;
import java.util.List;

/**
 *
 * @author ASUS
 */
public class NhaTaiTroService implements INhaTaiTroService{
    
    
    private INhaTaiTro dao;
    
    public NhaTaiTroService(){
        dao = new nhataitroDao();
    }
    
    @Override
    public boolean insert(nhataitro ntt) throws Exception {
        return dao.insert(ntt);
    }

    @Override
    public boolean update(nhataitro ntt) throws Exception {
        return dao.update(ntt);
    }

    @Override
    public boolean delet(String ntt) throws Exception {
        return dao.delet(ntt);
    }

    @Override
    public List<nhataitro> findAll() throws Exception {
        return dao.findAll();
    }

    @Override
    public List<nhataitro> timkiem(String s) throws Exception {
         return dao.timkiem(s);
    }

    @Override
    public nhataitro findbyid(int s) throws Exception {
        return dao.findbyid(s);
    }

    @Override
    public nhataitro findbyntt(String s) throws Exception {
        return dao.findbyntt(s);
    }
    
}
