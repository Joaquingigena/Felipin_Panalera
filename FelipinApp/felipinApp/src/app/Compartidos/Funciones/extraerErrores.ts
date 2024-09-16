
export function extraerErrores(obj:any):string[]{

    const error= obj.error.errors;

    let mensajesDeError: string[]=[];

    for(let llave in error){
        let campo= llave;

        const mensajeConCampos= error[llave].map((mensaje: string) => `${campo}: ${mensaje}`);

        mensajesDeError= mensajesDeError.concat(mensajeConCampos);

    }

    return mensajesDeError;
}