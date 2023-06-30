/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.btljava.controller;

import com.btljava.Service.INhaTaiTroService;
import com.btljava.Service.Impl.NhaTaiTroService;
import com.btljava.daos.INhaTaiTro;
import com.btljava.dao.impl.nhataitroDao;
import com.btljava.model.nhataitro;
import java.util.List;

/**
 *
 * @author ASUS
 */
public class NhaTaiTroController {
    private INhaTaiTroService dao;
    
    public NhaTaiTroController(){
        dao = new NhaTaiTroService();
    }
    
    
    public boolean insert(nhataitro ntt) throws Exception {
        return dao.insert(ntt);
    }

    
    public boolean update(nhataitro ntt) throws Exception {
        return dao.update(ntt);
    }

    
    public boolean delet(String ntt) throws Exception {
        return dao.delet(ntt);
    }

    
    public List<nhataitro> findAll() throws Exception {
        return dao.findAll();
    }

    
    public List<nhataitro> timkiem(String s) throws Exception {
         return dao.timkiem(s);
    }

    
    public nhataitro findbyid(int s) throws Exception {
        return dao.findbyid(s);
    }

    
    public nhataitro findbyntt(String s) throws Exception {
        return dao.findbyntt(s);
    }
}
