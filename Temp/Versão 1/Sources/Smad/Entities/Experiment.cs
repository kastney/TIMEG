using System;
using System.Collections.Generic;
using LiveShowStudio.Modules.ObjectSerializeManager;

namespace Smad.Entities {

    [Serializable]
    public class Experiment : IObject {

        public string Name { get; set; }

        [NonSerialized]
        private bool isSaved;
        public bool IsSaved { get { return isSaved; } set { isSaved = value; } }

        [NonSerialized]
        private string directory;
        public string Directory { get { return directory; } set { directory = value; } }

        public List<App> Apps { get; set; }

        public byte[] Icon { get; set; }

        public bool IsManual { get; set; }
        public string Type {
            get {
                if (IsManual) {
                    return "Projeto de avaliação manual";
                } else {
                    return "Projeto de avaliação automática";
                }
            }
        }

        public DateTime Stopwatch { get; set; }

        public List<Item> Items { get; set; }
        public string Group { get; set; }

        #region Constructors
        public Experiment() {
            Apps = new List<App>();
            IsManual = false;
            Group = "";
            Items = new List<Item> {
                ///======= IC-MEG =======
                //Interface do usuário
                new Item { Group = "IC-MEG", Code = "IU01", Category = "Interface do usuário", Name = "Os gráficos são agradáveis e atraentes?" },
                new Item { Group = "IC-MEG", Code = "IU02", Category = "Interface do usuário", Name = "Os gráficos possuem um layout eficiente?" },
                new Item { Group = "IC-MEG", Code = "IU03", Category = "Interface do usuário", Name = "O jogo maximiza a consistência e corresponde aos padrões?" },
                new Item { Group = "IC-MEG", Code = "IU04", Category = "Interface do usuário", Name = "O uso dos elementos multimídia seguem princípios de design de tela?" },
                new Item { Group = "IC-MEG", Code = "IU05", Category = "Interface do usuário", Name = "Os textos, fontes e cores são legíveis e compreensíveis?" },
                new Item { Group = "IC-MEG", Code = "IU06", Category = "Interface do usuário", Name = "A qualidade dos elementos multimídia como textos, imagens, animações, vídeos e sons são aceitáveis e agradáveis?" },
                new Item { Group = "IC-MEG", Code = "IU07", Category = "Interface do usuário", Name = "O jogo possui elementos multimídias?" },
                new Item { Group = "IC-MEG", Code = "IU08", Category = "Interface do usuário", Name = "Os elementos multimídias acomodam todo o texto fornecido no jogo?" },
                new Item { Group = "IC-MEG", Code = "IU09", Category = "Interface do usuário", Name = "A integração dos meios de apresentação é bem coordenada?" },
                new Item { Group = "IC-MEG", Code = "IU10", Category = "Interface do usuário", Name = "O uso dos elementos multimídia aprimora a apresentação das informações?" },
                new Item { Group = "IC-MEG", Code = "IU11", Category = "Interface do usuário", Name = "A interação com o material didático é adequada ao nível do estudante?" },
                new Item { Group = "IC-MEG", Code = "IU12", Category = "Interface do usuário", Name = "A interface oferece ao usuário chaves auto indicada para tarefas (saída, nome dos objetivos, glossário)?" },
                new Item { Group = "IC-MEG", Code = "IU13", Category = "Interface do usuário", Name = "Interface do dispositivo e a interface do jogo são utilizados para seus próprios fins?" },
                new Item { Group = "IC-MEG", Code = "IU14", Category = "Interface do usuário", Name = "Os controles são projetados de forma que seja conveniente aos inputs dos jogadores?" },
                new Item { Group = "IC-MEG", Code = "IU15", Category = "Interface do usuário", Name = "Os controles são flexíveis?" },
                new Item { Group = "IC-MEG", Code = "IU16", Category = "Interface do usuário", Name = "Os controles são personalizáveis conforme as necessidades dos jogadores?" },
                new Item { Group = "IC-MEG", Code = "IU17", Category = "Interface do usuário", Name = "O jogo fornece feedbacks das ações do jogador?" },
                new Item { Group = "IC-MEG", Code = "IU18", Category = "Interface do usuário", Name = "O jogo não permite acontecer erros irreversíveis?" },
                new Item { Group = "IC-MEG", Code = "IU19", Category = "Interface do usuário", Name = "A recuperação após um erro é facilitada?" },
                new Item { Group = "IC-MEG", Code = "IU20", Category = "Interface do usuário", Name = "O jogador não precisa memorizar coisas desnecessariamente?" },
                new Item { Group = "IC-MEG", Code = "IU21", Category = "Interface do usuário", Name = "O jogo contém ajuda, dicas e/ou tutoriais?" },
                new Item { Group = "IC-MEG", Code = "IU22", Category = "Interface do usuário", Name = "A navegação da interface é fácil, consistente, lógica e precisa?" },
                new Item { Group = "IC-MEG", Code = "IU23", Category = "Interface do usuário", Name = "O jogo suporte a múltiplos idiomas?" },
                //Pedagogia
                new Item { Group = "IC-MEG", Code = "PE01", Category = "Pedagogia", Name = "É claro como o conteúdo do jogo se relaciona com a disciplina?" },
                new Item { Group = "IC-MEG", Code = "PE02", Category = "Pedagogia", Name = "As atividades são interessantes e envolventes?" },
                new Item { Group = "IC-MEG", Code = "PE03", Category = "Pedagogia", Name = "O conteúdo é confiável e comprovado?" },
                new Item { Group = "IC-MEG", Code = "PE04", Category = "Pedagogia", Name = "O jogo suporta aprendizado auto dirigida?" },
                new Item { Group = "IC-MEG", Code = "PE05", Category = "Pedagogia", Name = "O jogo fornece suporte para habilidades de autoaprendizado?" },
                new Item { Group = "IC-MEG", Code = "PE06", Category = "Pedagogia", Name = "O jogo permite meios para aprender fazendo?" },
                new Item { Group = "IC-MEG", Code = "PE07", Category = "Pedagogia", Name = "O jogo considera diferenças individuais do jogador?" },
                new Item { Group = "IC-MEG", Code = "PE08", Category = "Pedagogia", Name = "O desempenho do jogador é baseado em resultados?" },
                new Item { Group = "IC-MEG", Code = "PE09", Category = "Pedagogia", Name = "O jogo possui opção de escolha do nível de dificuldades?" },
                new Item { Group = "IC-MEG", Code = "PE10", Category = "Pedagogia", Name = "O jogo permite meios para o jogador prosseguir em seu próprio ritmo?" },
                new Item { Group = "IC-MEG", Code = "PE11", Category = "Pedagogia", Name = "O jogo contribui para a aprendizagem na disciplina?" },
                new Item { Group = "IC-MEG", Code = "PE12", Category = "Pedagogia", Name = "O jogo é eficiente na aprendizagem em comparação a outras atividades da disciplina?" },
                //Conteúdo
                new Item { Group = "IC-MEG", Code = "CO01", Category = "Conteúdo", Name = "O jogo possui poucas notificações?" },
                new Item { Group = "IC-MEG", Code = "CO02", Category = "Conteúdo", Name = "O jogo possui animações ou vídeos interno?" },
                new Item { Group = "IC-MEG", Code = "CO03", Category = "Conteúdo", Name = "O jogo possui grande variedade de conteúdo?" },
                new Item { Group = "IC-MEG", Code = "CO04", Category = "Conteúdo", Name = "O jogo não possui conteúdo bloqueado que precise comprar para prosseguir no jogo?" },
                new Item { Group = "IC-MEG", Code = "CO05", Category = "Conteúdo", Name = "A quantidade de anúncios evasivos não pode ocorrer repetidas vezes em um curto período?" },
                new Item { Group = "IC-MEG", Code = "CO06", Category = "Conteúdo", Name = "O jogo possui conteúdo de aprendizagem?" },
                new Item { Group = "IC-MEG", Code = "CO07", Category = "Conteúdo", Name = "O conteúdo confiável é e com fluxo correto?" },
                new Item { Group = "IC-MEG", Code = "CO08", Category = "Conteúdo", Name = "O conteúdo é estruturado/organizado de forma clara e compreensível?" },
                new Item { Group = "IC-MEG", Code = "CO09", Category = "Conteúdo", Name = "A navegação do conteúdo é fácil, consistente, lógica e precisa?" },
                new Item { Group = "IC-MEG", Code = "CO10", Category = "Conteúdo", Name = "O conteúdo do jogo é suficiente e relevante?" },
                new Item { Group = "IC-MEG", Code = "CO11", Category = "Conteúdo", Name = "Os materiais são interessantes e envolventes?" },
                new Item { Group = "IC-MEG", Code = "CO12", Category = "Conteúdo", Name = "O conteúdo do jogo é aprendido facilmente?" },
                new Item { Group = "IC-MEG", Code = "CO13", Category = "Conteúdo", Name = "O objetivo de aprendizagem é alcançado?" },
                new Item { Group = "IC-MEG", Code = "CO14", Category = "Conteúdo", Name = "O jogo reduzir a quantidade de conteúdo bloqueado?" },
                //Aprendizagem percebida
                new Item { Group = "IC-MEG", Code = "AP01", Category = "Aprendizagem percebida", Name = "A mecânica do jogo é aprendida facilmente?" },
                new Item { Group = "IC-MEG", Code = "AP02", Category = "Aprendizagem percebida", Name = "A mecânica do jogo é aprendida rapidamente?" },
                new Item { Group = "IC-MEG", Code = "AP03", Category = "Aprendizagem percebida", Name = "Não é preciso de conhecimentos prévios para jogar?" },
                new Item { Group = "IC-MEG", Code = "AP04", Category = "Aprendizagem percebida", Name = "A mecânica do jogo é fácil de ser compreendida?" },
                //Multimídia
                new Item { Group = "IC-MEG", Code = "MM01", Category = "Multimídia", Name = "O uso dos elementos multimídia como textos, imagens, animações, vídeos e sons são aceitáveis?" },
                new Item { Group = "IC-MEG", Code = "MM02", Category = "Multimídia", Name = "A combinação dos elementos multimídia como textos, imagens, animações, vídeos e sons são aceitáveis?" },
                new Item { Group = "IC-MEG", Code = "MM03", Category = "Multimídia", Name = "A apresentação dos elementos multimídias é bem gerenciada?" },
                new Item { Group = "IC-MEG", Code = "MM04", Category = "Multimídia", Name = "Os elementos multimídias é adequado para uso “específico”?" },
                //Jogabilidade
                new Item { Group = "IC-MEG", Code = "JO01", Category = "Jogabilidade", Name = "O desafio do jogo é adequado ao nível do usuário?" },
                new Item { Group = "IC-MEG", Code = "JO02", Category = "Jogabilidade", Name = "Os jogadores são capazes de desenvolver estratégias?" },
                new Item { Group = "IC-MEG", Code = "JO03", Category = "Jogabilidade", Name = "Os desafios, as estratégias, o ritmo estão em equilíbrio?" },
                new Item { Group = "IC-MEG", Code = "JO04", Category = "Jogabilidade", Name = "Os jogadores são capazes de controlar o jogo?" },
                new Item { Group = "IC-MEG", Code = "JO05", Category = "Jogabilidade", Name = "Os jogadores são capazes de conhecer o progressodo jogo?" },
                new Item { Group = "IC-MEG", Code = "JO06", Category = "Jogabilidade", Name = "Os jogadores são recompensados" },
                new Item { Group = "IC-MEG", Code = "JO07", Category = "Jogabilidade", Name = "As recompensas são significativas?" },
                new Item { Group = "IC-MEG", Code = "JO08", Category = "Jogabilidade", Name = "A primeira experiência é encorajadora?" },
                new Item { Group = "IC-MEG", Code = "JO09", Category = "Jogabilidade", Name = "A primeira experiência chama a atenção do jogador?" },
                new Item { Group = "IC-MEG", Code = "JO10", Category = "Jogabilidade", Name = "A história do jogo é significativa?" },
                new Item { Group = "IC-MEG", Code = "JO11", Category = "Jogabilidade", Name = "As mecânicas, os objetivos, as tarefas não são monótonos ou repetitivos?" },
                new Item { Group = "IC-MEG", Code = "JO12", Category = "Jogabilidade", Name = "O jogo não trava ou fica estagnado?" },
                new Item { Group = "IC-MEG", Code = "JO13", Category = "Jogabilidade", Name = "A jogabilidade e as funcionalidade do jogo são estáveis e consistentes?" },
                new Item { Group = "IC-MEG", Code = "JO14", Category = "Jogabilidade", Name = "O jogo possui objetivos claros?" },
                new Item { Group = "IC-MEG", Code = "JO15", Category = "Jogabilidade", Name = "O jogo possui metas de aprendizado?" },
                new Item { Group = "IC-MEG", Code = "JO16", Category = "Jogabilidade", Name = "O jogo possui um modo offline?" },
                new Item { Group = "IC-MEG", Code = "JO17", Category = "Jogabilidade", Name = "O jogo aumenta o progresso devido ao esforço do jogador?" },
                //Interação social
                new Item { Group = "IC-MEG", Code = "IS01", Category = "Interação social", Name = "O jogo possui um modo multijogadores online?" },
                new Item { Group = "IC-MEG", Code = "IS02", Category = "Interação social", Name = "O jogo não obriga o jogador a criar uma conta de usuário para jogar?" },
                //Mobilidade
                new Item { Group = "IC-MEG", Code = "MO01", Category = "Mobilidade", Name = "As sessões do jogo podem ser inicializadas rapidamente?" },
                new Item { Group = "IC-MEG", Code = "MO02", Category = "Mobilidade", Name = "O jogo não fecha inesperadamente e todas as interrupções são tratadas adequadamente?" },
                new Item { Group = "IC-MEG", Code = "MO03", Category = "Mobilidade", Name = "O jogo se acomoda adequadamente com as bordas da tela do dispositivo?" },
                new Item { Group = "IC-MEG", Code = "MO04", Category = "Mobilidade", Name = "A instalação do jogo é rápida e consistente no dispositivo?" },
                new Item { Group = "IC-MEG", Code = "MO05", Category = "Mobilidade", Name = "O jogo não pode consumir significativamente o armazenamento do dispositivo?" },
                new Item { Group = "IC-MEG", Code = "MO06", Category = "Mobilidade", Name = "A desinstalação é rápida e consistente no dispositivo?" },
                new Item { Group = "IC-MEG", Code = "MO07", Category = "Mobilidade", Name = "O consumo da bateria do dispositivo é consistente, não havendo um consumo exagerado?" },

                ///======= mGBL =======
                //Interface do usuário
                new Item { Group = "mGBL", Code = "GU01", Category = "Interface do usuário", Name = "O jogo suporta representação audiovisual." },
                new Item { Group = "mGBL", Code = "GU02", Category = "Interface do usuário", Name = "O layout da tela é eficiente e visualmente agradável." },
                new Item { Group = "mGBL", Code = "GU03", Category = "Interface do usuário", Name = "A interface do dispositivo e a interface do jogo são usadas para seus próprios fins." },
                new Item { Group = "mGBL", Code = "GU04", Category = "Interface do usuário", Name = "A navegação é consistente, lógica e minimalista." },
                new Item { Group = "mGBL", Code = "GU05", Category = "Interface do usuário", Name = "As teclas de controle são consistentes e seguem as convenções padrão." },
                new Item { Group = "mGBL", Code = "GU06", Category = "Interface do usuário", Name = "Os controles do jogo são convenientes e flexíveis." },
                new Item { Group = "mGBL", Code = "GU07", Category = "Interface do usuário", Name = "O jogo dá feedback sobre as ações do jogador." },
                new Item { Group = "mGBL", Code = "GU08", Category = "Interface do usuário", Name = "O jogador não pode cometer erros irreversíveis." },
                new Item { Group = "mGBL", Code = "GU09", Category = "Interface do usuário", Name = "O jogador não precisa memorizar coisas desnecessariamente." },
                new Item { Group = "mGBL", Code = "GU10", Category = "Interface do usuário", Name = "O jogo contém ajuda." },
                //Mobilidade
                new Item { Group = "mGBL", Code = "MO01", Category = "Mobilidade", Name = "As sessões do jogo podem ser iniciadas rapidamente." },
                new Item { Group = "mGBL", Code = "MO02", Category = "Mobilidade", Name = "O jogo acomoda com os arredores. (Bordas da tela do dispositivo)." },
                new Item { Group = "mGBL", Code = "MO03", Category = "Mobilidade", Name = "As interrupções são tratadas razoavelmente." },
                //Game play
                new Item { Group = "mGBL", Code = "GP01", Category = "Jogabilidade", Name = "O jogo fornece objetivos claros." },
                new Item { Group = "mGBL", Code = "GP02", Category = "Jogabilidade", Name = "O jogador vê o progresso no jogo e pode comparar." },
                new Item { Group = "mGBL", Code = "GP03", Category = "Jogabilidade", Name = "Os jogadores são recompensados e as recompensas são significativas." },
                new Item { Group = "mGBL", Code = "GP04", Category = "Jogabilidade", Name = "O jogador está no controle." },
                new Item { Group = "mGBL", Code = "GP05", Category = "Jogabilidade", Name = "Desafio, estratégia e ritmo estão em equilíbrio." },
                new Item { Group = "mGBL", Code = "GP06", Category = "Jogabilidade", Name = "A primeira experiência é encorajadora." },
                new Item { Group = "mGBL", Code = "GP07", Category = "Jogabilidade", Name = "A história do jogo suporta a jogabilidade e é significativa." },
                new Item { Group = "mGBL", Code = "GP08", Category = "Jogabilidade", Name = "Não há tarefas repetitivas ou chatas." },
                new Item { Group = "mGBL", Code = "GP09", Category = "Jogabilidade", Name = "O jogo não fica estagnado." },
                new Item { Group = "mGBL", Code = "GP10", Category = "Jogabilidade", Name = "A jogabilidade do jogo é consistente." },
                //Conteúdo de aprendizagem
                new Item { Group = "mGBL", Code = "CO01", Category = "Conteúdo de aprendizagem", Name = "O conteúdo pode ser aprendido facilmente." },
                new Item { Group = "mGBL", Code = "CO02", Category = "Conteúdo de aprendizagem", Name = "O jogo fornece conteúdo de aprendizagem." },
                new Item { Group = "mGBL", Code = "CO03", Category = "Conteúdo de aprendizagem", Name = "O objetivo de aprendizagem do jogo é alcançado." },
                new Item { Group = "mGBL", Code = "CO04", Category = "Conteúdo de aprendizagem", Name = "O conteúdo é compreensível." },
                
                ///======= PHEG =======
                //Usabilidade
                new Item { Group = "PHEG", Code = "UI01", Category = "Interface do usuário", Name = "Usa design estético e minimalista" },
                new Item { Group = "PHEG", Code = "UI02", Category = "Interface do usuário", Name = "Maximiza a consistência e corresponde aos padrões" },
                new Item { Group = "PHEG", Code = "UI03", Category = "Interface do usuário", Name = "Os usos do espaço, cor e texto estão de acordo com os princípios do design da tela" },
                new Item { Group = "PHEG", Code = "UI04", Category = "Interface do usuário", Name = "Os usos de texto, cor e fonte seguem os princípios de legibilidade." },
                new Item { Group = "PHEG", Code = "UI05", Category = "Interface do usuário", Name = "A qualidade dos elementos multimídia (texto, imagem, animação, vídeo e som) utilizados é aceitável." },
                new Item { Group = "PHEG", Code = "UI06", Category = "Interface do usuário", Name = "O uso de elementos multimídia suporta significativamente o texto fornecido." },
                new Item { Group = "PHEG", Code = "UI07", Category = "Interface do usuário", Name = "A integração dos meios de apresentação é bem coordenada." },
                new Item { Group = "PHEG", Code = "UI08", Category = "Interface do usuário", Name = "O uso de elementos multimídia aprimora a apresentação das informações." },
                new Item { Group = "PHEG", Code = "UI09", Category = "Interface do usuário", Name = "A interatividade do material didático é adequada ao nível dos estudantes/alunos." },
                new Item { Group = "PHEG", Code = "UI10", Category = "Interface do usuário", Name = "Fornecer chave específica e auto identificada para tarefa específica (saída, glossário, principal, objetivo)." },
                //Educação/Pedagogia
                new Item { Group = "PHEG", Code = "ED01", Category = "Educação/Pedagogia", Name = "Objetivos claros e com metas de aprendizado." },
                new Item { Group = "PHEG", Code = "ED02", Category = "Educação/Pedagogia", Name = "As atividades são interessantes e envolventes." },
                new Item { Group = "PHEG", Code = "ED03", Category = "Educação/Pedagogia", Name = "O design e o conteúdo são confiáveis e comprovados." },
                new Item { Group = "PHEG", Code = "ED04", Category = "Educação/Pedagogia", Name = "Pode ser usado como ferramentas de aprendizado autodirigidas." },
                new Item { Group = "PHEG", Code = "ED05", Category = "Educação/Pedagogia", Name = "Suporte para habilidades de autoaprendizagem." },
                new Item { Group = "PHEG", Code = "ED06", Category = "Educação/Pedagogia", Name = "Meio para aprender fazendo." },
                new Item { Group = "PHEG", Code = "ED07", Category = "Educação/Pedagogia", Name = "Considera as diferenças individuais." },
                new Item { Group = "PHEG", Code = "ED08", Category = "Educação/Pedagogia", Name = "O desempenho deve ser baseado em resultados." },
                new Item { Group = "PHEG", Code = "ED09", Category = "Educação/Pedagogia", Name = "Oferece a capacidade de selecionar o nível de dificuldade nos jogos." },
                new Item { Group = "PHEG", Code = "ED10", Category = "Educação/Pedagogia", Name = "Capacidade do jogador trabalhar no seu próprio ritmo." },
                //Conteúdo
                new Item { Group = "PHEG", Code = "CO01", Category = "Conteúdo", Name = "Conteúdo confiável com fluxo correto." },
                new Item { Group = "PHEG", Code = "CO02", Category = "Conteúdo", Name = "Estrutura clara e compreensível do conteúdo." },
                new Item { Group = "PHEG", Code = "CO03", Category = "Conteúdo", Name = "A navegação é fácil e precisa." },
                new Item { Group = "PHEG", Code = "CO04", Category = "Conteúdo", Name = "Os materiais de apoio são suficientes e relevantes." },
                new Item { Group = "PHEG", Code = "CO05", Category = "Conteúdo", Name = "Os materiais são interessantes e envolventes." },
                //Multimídia
                new Item { Group = "PHEG", Code = "MM01", Category = "Multimídia", Name = "O uso de elementos multimídia é aceitável." },
                new Item { Group = "PHEG", Code = "MM02", Category = "Multimídia", Name = "A combinação de elementos multimídia é adequada." },
                new Item { Group = "PHEG", Code = "MM03", Category = "Multimídia", Name = "A apresentação de elementos multimídia é bem gerenciada." },
                new Item { Group = "PHEG", Code = "MM04", Category = "Multimídia", Name = "Adequação dos elementos multimídia para uso específico." },
                //Jogabilidade
                new Item { Group = "PHEG", Code = "PL01", Category = "Jogabilidade", Name = "O desafio fornecido é de acordo com o padrão do usuário." },
                new Item { Group = "PHEG", Code = "PL02", Category = "Jogabilidade", Name = "Usuários são capazes de estratégias." },
                new Item { Group = "PHEG", Code = "PL03", Category = "Jogabilidade", Name = "O ritmo do jogo está em equilíbrio." },
                new Item { Group = "PHEG", Code = "PL04", Category = "Jogabilidade", Name = "Jogadores são capazes de controlar o jogo." },
                new Item { Group = "PHEG", Code = "PL05", Category = "Jogabilidade", Name = "Jogadores são capazes de conhecer o progresso do jogo." },
            };
        }
        #endregion
    }
}